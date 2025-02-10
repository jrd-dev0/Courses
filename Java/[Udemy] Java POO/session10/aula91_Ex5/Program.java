package aula91_Ex5;

import java.util.Locale;
import java.util.Scanner;

public class Program {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		System.out.printf("Quantos numeros voce vai digitar? ");
		int n = sc.nextInt();
		
		double[] numeros = new double[n];
		
		for(int i = 0; i < n; i++) {
			
			System.out.printf("Digite um numero: ");
			numeros[i] = sc.nextDouble();
		}
		
		double maior = 0.0;
		int posicao = 0;
		
		for(int i = 0; i < numeros.length; i++) {
			
			if(numeros[i] > maior) {
				maior = numeros[i];
				posicao = i;
			}
		}
		
		System.out.printf("MAIOR VALOR = %.1f%n", maior);
		System.out.printf("POSICAO DO MAIOR VALOR = %d", posicao);
		
		sc.close();
	}
}
