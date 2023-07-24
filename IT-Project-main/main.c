#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include "myconio.h"
#include "K8055D_C.h"

void affichage(int compteur);

/*La liste des chiffre enrigstré dans 10 matrice 5x4*/
const char segments[10][5][4] = {
    {" _ ",
     "| |",
     "|_|",
     "   "}, /*0*/
    {
        "   ",
        "  |",
        "  |",
        "   "}, /*1*/
    {
        " _ ",
        " _|",
        "|_ ",
        "   "}, /*2*/
    {
        " _ ",
        " _|",
        " _|",
        "   "}, /*3*/
    {
        "   ",
        "|_|",
        "  |",
        "   "}, /*4*/
    {
        " _ ",
        "|_ ",
        " _|",
        "   "}, /*5*/
    {
        " _ ",
        "|_ ",
        "|_|",
        "   "}, /*6*/
    {
        " _ ",
        "  |",
        "  |",
        "   "}, /*7*/
    {
        " _ ",
        "|_|",
        "|_|",
        "   "}, /*8*/
    {
        " _ ",
        "|_|",
        " _|",
        "   "} /*9*/
};

int main()
{
    int compteur;

    char increment;

    int j = 1;

    int tab[4];

    int i = 0, symbole, NbreDecimal, entree = 0, dizaine, carry = 0, k = 0, verif[4], load10 = 0, stop = 0;

    char c;

    /*Stylisation de la fenêtre*/
    textcolor(BLACK);
    textbackground(DARKGRAY);
    MYclrwin(1, 1, 80, 30);
    textbackground(LIGHTRED);
    MYclrwin(10, 3, 70, 3);
    gotoxy(35, 3);
    printf("Compteur");
    textbackground(WHITE);
    MYclrwin(10, 4, 70, 30);

    /*Si on arrive pas a se connecter afficher erreur sinon device is connected*/

    /*-----------Connexion a la carte de com----------*/
    if (-1 == OpenDevice(0))
    {
        printf("Unable to open device");
        exit(1);
    }
    printf("Device is connected\n");

    /*----Clear all-------*/
    SetAllDigital();

    do
    {

        /*----Clear all-------*/
        SetAllDigital();
        /*--------Buzzer-------*/
        ClearDigitalChannel(5);

        load10 = 0;
        compteur = 0;
        increment = ' ';
        carry = 0;
        NbreDecimal = 0;
        symbole = 0;
        entree = 0;
        dizaine = 0;
        k = 0;
        stop = 0;
        i = 0;

        /*-------------------Initialisation du compteur-------------------*/
        do
        {
            gotoxy(12, 7);
            printf("A quelle valeur voulez vous intialiser le compteur : ");
            scanf("%d", &compteur);
            fflush(stdin);

        } while (compteur < 0 || compteur > 19);

        affichage(compteur);

        /*-----Si compteur>10 on garde juste les unités---------*/
        if (compteur >= 10)
        {
            compteur = compteur % 10;
            ClearDigitalChannel(8);
            load10 = 1;
        }

        /*---------Set le preset----------------*/
        ClearDigitalChannel(7);

        NbreDecimal = compteur;

        /*---------------------On va load les sorties de la carte de comm-------------------*/
        do
        {
            symbole = NbreDecimal % 2;
            NbreDecimal = NbreDecimal / 2;
            i++;
            /*Set les outpouts sur les channels*/
            if (symbole == 0)
            {
                SetDigitalChannel(i);
            }
            else
            {
                ClearDigitalChannel(i);
            }
        } while (NbreDecimal > 0);

        /*-------------Demande d'incrémentation ou de décrementation--------------*/
        gotoxy(12, 16);
        do
        {
            printf("Entr\202 + pour incr\202menter, - pour d\202cr\202menter: ");
            increment = getchar();
            fflush(stdin);
        } while (increment != '+' && increment != '-');

        /*--------Sortie pour le compteur--------*/
        if (increment == '+')
        {
            ClearDigitalChannel(6);
        }
        else
        {
            SetDigitalChannel(6);
        }

        /*------On clear le preset----------*/
        SetDigitalChannel(7);

        /*------------------Quitte quand on est a 0 ou 19-----------------------*/
        while (stop == 0)
        {
            entree = 0;

            j = 1;

            /*--------Detecte le carry out---------*/
            dizaine = ReadDigitalChannel(5);

            /*-----Sauvgarde du carry out-------*/
            if (dizaine == 1 && compteur != 0)
            {
                carry = dizaine;
            }

            /*----Si je suis en mode incrémentation et que j'ai plus de 10 en load entrée + 10-------*/
            if (increment == '+' && load10 == 1)
            {
                entree += 10;
            }

            /*-------Sinon on est en décrementation on met +10 et si load10=0 on remet l'entrée à 0-----*/
            else
            {
                if (load10 == 1)
                {
                    entree += 10;
                }
                else
                {
                    entree = 0;
                }
            }

            /*-----------------Boucle qui permet de lire nos entrées-------------------*/
            for (int i = 0; i < 4; i++)
            {
                /*Reconvertir les entrées de binaires a décimal*/
                tab[i] = !ReadDigitalChannel(i + 1);
                entree = tab[i] * j + entree;
                j *= 2;
            }

            /*---------Lire toute les entrée pour vérifier après-------------*/
            for (int i = 0; i < 4; i++)
            {
                verif[i] = !ReadDigitalChannel(i + 1);
            }

            if (increment == '+')
            {
                /*--------Check toute si toutes les entrées sont a 0 et un carry-----------*/
                /*--------Pour afficher le nombre 10----------*/
                if (verif[0] == 0 && verif[1] == 0 && verif[2] == 0 && verif[3] == 0 && carry == 1)
                {
                    entree = 0;
                    /*-----On affiche le 1 des dizaines---*/
                    ClearDigitalChannel(8);
                    entree += 10;
                    k = 0;
                }
                /*--- Si le load est en dessous de 10 et que on a un carry out on fait notre entree +10----*/
                else if (carry == 1 && entree != 9 && load10 != 1)
                {
                    k = 10;
                }
            }
            /*--------Check si on  a 9 et que on a eu un carry out-----------*/
            else if (verif[0] == 1 && verif[1] == 0 && verif[2] == 0 && verif[3] == 1 && carry == 1)
            {
                /*----On retire le 1 des dizaines----*/
                SetDigitalChannel(8);
                entree -= 10;
                carry = 0;
                load10 = 0;
            }

            entree = entree + k;
            compteur = entree;

            affichage(compteur);
            _sleep(200);
            /*---Nettoyer l'écran-----*/
            textbackground(WHITE);
            MYclrwin(10, 4, 70, 30);

            /*-----On stop si compteur = 0 ou 19----*/
            if ((compteur == 19 && increment == '+') || (compteur == 0 && increment == '-'))
                stop = 1;
        }

        /*----Remettre le preset pour pouvoir bloquer le compteur-----*/
        ClearDigitalChannel(7);

        if (increment == '+')
        {
            /*---On bloque le compteur à 19----*/
            ClearDigitalChannel(1);
            SetDigitalChannel(2);
            SetDigitalChannel(3);
            ClearDigitalChannel(4);
        }
        /*------On bloque à 0 en décrementation-----*/
        else
        {
            for (i = 1; i < 5; i++)
                SetDigitalChannel(i);
        }

        /*-------Allume le buzzer à 0 ou à 19----*/
        for (i = 0; i < 3; i++)
        {
            SetDigitalChannel(5);
            _sleep(400);
            ClearDigitalChannel(5);
            _sleep(400);
        }

        /*----------prompt pour recommencer le programme----------------*/
        do
        {
            printf("Voulez vous continuez le programme ? o/n: ");
            c = getchar();
        } while (c != 'n' && c != 'o');

    } while (c != 'n');

    /*---Tout éteindre---*/
    ClearDigitalChannel(8);
    for (i = 1; i < 5; i++)
    {
        ClearDigitalChannel(i);
    }
    SetAllDigital();
    ClearDigitalChannel(5);

    return 0;
}

void affichage(int compteur)
{
    int ligne, unite, dizaine, x = 12, y = 10;
    unite = compteur % 10;
    dizaine = (compteur / 10) % 2;
    gotoxy(x, y);
    for (ligne = 0; ligne < 5; ligne++)
    {
        printf("%s", segments[dizaine][ligne]);
        /*Séparer les deux chiffres dans l'affichage*/
        printf(" ");
        printf("%s", segments[unite][ligne]);
        /*On passe d'une ligne*/
        gotoxy(x, y += 1);
    }
}
