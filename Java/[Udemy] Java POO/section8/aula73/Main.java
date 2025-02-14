package aula73;

import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		System.out.printf("What is the dollar price? ");
		double dolarPrice = sc.nextDouble();
		System.out.printf("How many dollars will be bought? ");
		double dolarAmount = sc.nextDouble();
		
		System.out.printf("Amount to be paid in reais = %.2f%n", CurrencyConverter.Real(dolarPrice, dolarAmount));
		sc.close();
	}

}
