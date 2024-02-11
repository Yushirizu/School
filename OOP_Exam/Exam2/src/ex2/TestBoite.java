/*********ROSSI ULYSSE - EX2*********/

package ex2;

import java.util.Scanner;

public class TestBoite {

	public static void main(String[] args) {
		Boite a = new Boite(10, 20, 30);
		Boite b = new Boite(20, 30, 40, 'M');
		Boite c = new Boite(10, 50, 20, 'G');

		Scanner clav = new Scanner(System.in);

		a.affCaracteristique();
		b.affCaracteristique();
		c.affCaracteristique();

		a.alteration('M');

		a.affCaracteristique();

		System.out.println("La haute de la boite a est: " + a.getHauteur() + "mm");

		System.out.println("Le volume de la boite a est: " + a.volume() + "dm3");

		System.out.println("Le nombre de boite créé est de " + Boite.getNombreBoite() + " boite(s)");

		System.out.println("Entrez les dimensions : la largeur");
		int largeur = clav.nextInt();
		System.out.println("Entrez la longueur ");
		int longeur = clav.nextInt();
		System.out.println("Entrez la hauteur ");
		int hauteur = clav.nextInt();

		Boite custom = new Boite(longeur, largeur, hauteur);

		custom.affDimension();

		clav.close();
	}

}
