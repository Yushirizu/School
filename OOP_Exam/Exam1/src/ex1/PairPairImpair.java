/*********ROSSI ULYSSE - EX1*********/

package ex1;

import java.util.Random;

public class PairPairImpair {
	public static void main(String[] args) {
		int rand[] = new int[3];
		int nbrEssai = 0;

		Random nbr = new Random();

		do {
			for (int i = 0; i < rand.length; i++) {
				/* Chiffre de 0 inclu à 1001 non inclu */
				rand[i] = nbr.nextInt(1001);
			}
			nbrEssai++;
		} while (rand[0] % 2 != 0 || rand[1] % 2 != 0 || rand[2] % 2 != 1);

		System.out.println("Cela a demander " + nbrEssai + " essai(s) et les chiffres sont :");

		for (int i = 0; i < rand.length; i++) {
			System.out.println(rand[i]);
		}
	}

}
