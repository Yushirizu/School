/*********ROSSI ULYSSE - EX3*********/

package ex3;

import java.util.Scanner;

public class TestColis {

	public static void main(String[] args) {
		int longueur, largeur, hauteur, poids;
		float prix, prixAuPoids;
		Scanner clav = new Scanner(System.in);

		System.out.print("L'objet à envoyer a les dimensions suivantes : ");
		longueur = clav.nextInt();
		largeur = clav.nextInt();
		hauteur = clav.nextInt();
		System.out.print("et son poids est de ");
		poids = clav.nextInt();

		Colis a = new Colis(longueur, largeur, hauteur, poids);

		prixAuPoids = a.getPrixAuPoids();
		Boite boiteduColis = Colis.choixBoite(largeur, longueur, hauteur);
		prix = Colis.prixBoite(boiteduColis);

		System.out.println("Prix de l'envoi = " + prix + "€ + " + prixAuPoids + "€ = " + (prix + prixAuPoids) + "€");

		clav.close();
	}

}
