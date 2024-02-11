/*********ROSSI ULYSSE - EX3*********/

package ex3;

public class Colis extends Boite {

	private int poids;
	private static int nbrcolis = 0;

	/* Différentes boites disponibles */
	private static Boite bP4 = new Boite(155, 115, 74);
	private static Boite bP5 = new Boite(230, 115, 74);
	private static Boite bP6 = new Boite(263, 188, 98);
	private static Boite bP7 = new Boite(310, 220, 98);

	/* Dimensions et poids */
	public Colis(int longeur, int largeur, int hauteur, int poids) {
		super(longeur, largeur, hauteur);
		this.poids = poids;
		nbrcolis++;
	}

	/* Boite et poids */
	public Colis(int longeur, int largeur, int hauteur, int poids, Boite a) {
		super(longeur, largeur, hauteur);
		this.poids = poids;
		nbrcolis++;
	}

	/* Méthode d'accès au poids */
	public int getPoids() {
		return poids;
	}

	/* Méthode d'accès aux prixAuPoids */
	public float getPrixAuPoids() {
		return prixAuPoids(poids);
	}

	/* Retourne le nombre de coli */
	public static int getNombreColis() {
		return nbrcolis;
	}

	/* Calcule le prix au poids */
	private float prixAuPoids(int poids) {
		if (poids <= 5) {
			return 5.2f;
		} else if (poids < 10) {
			return 6.2f;
		} else {
			return 10.7f;
		}
	}

	/* Détermine la boite en fonction de la taille de l'objet */
	public static Boite choixBoite(int largeur, int longueur, int hauteur) {	
		if (longueur > 300 && largeur > 200 && hauteur > 90) {
			throw new IllegalArgumentException("l'objet est trop grand");
		} else if (longueur > 263 || largeur > 188 || hauteur > 98) {
			return bP7;
		} else if (longueur > 230 || largeur > 115 || hauteur > 74) {
			return bP6;
		} else if (longueur > 155) {
			return bP5;
		} else {
			return bP4;
		}

	}

	/* Détermine le prix en fonction des dimensions de la boite */
	public static float prixBoite(Boite a) {

		int longueur = a.getLongeur();

		switch (longueur) {
		case 155:
			return 1.95f;
		case 230:
			return 2.1f;
		case 263:
			return 2.25f;
		case 310:
			return 2.45f;
		default:
			return 0f;
		}
	}
}
