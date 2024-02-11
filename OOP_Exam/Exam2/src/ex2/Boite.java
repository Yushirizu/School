/*********ROSSI ULYSSE - EX2*********/

package ex2;

public class Boite {
	private int longeur;
	private int largeur;
	private int hauteur;
	private char matiere;
	private static int nbrboite = 0;

	/* Que dimensions */
	public Boite(int longeur, int largeur, int hauteur) {
		nbrboite++;
		this.longeur = longeur;
		this.largeur = largeur;
		this.hauteur = hauteur;
		matiere = 'C';
	}

	/* Dimensions et matière */
	public Boite(int longeur, int largeur, int hauteur, char matiere) {
		nbrboite++;
		this.longeur = longeur;
		this.largeur = largeur;
		this.hauteur = hauteur;
		this.matiere = matiere;
		matiere = 'C';
	}

	/* GETTER */

	public int getLongeur() {
		return longeur;
	}

	public int getLargeur() {
		return largeur;
	}

	public int getHauteur() {
		return hauteur;
	}

	public char getMatiere() {
		return matiere;
	}

	public void alteration(char matiere) {
		this.matiere = matiere;
	}

	public int volume() {
		int volume = ((this.longeur) * (this.largeur) * (this.hauteur)) / 100;

		return volume;
	}

	public static int getNombreBoite() {
		return nbrboite;
	}

	public void affDimension() {
		System.out.println("La boite a " + this.longeur + "mm de longueur " + this.largeur + "mm de largeur "
				+ this.hauteur + "mm de hauteur ");
	}

	public void affCaracteristique() {
		System.out.println("La boite a " + this.longeur + "mm de longueur " + this.largeur + "mm de largeur "
				+ this.hauteur + "mm de hauteur et de matière " + this.matiere);
	}

}
