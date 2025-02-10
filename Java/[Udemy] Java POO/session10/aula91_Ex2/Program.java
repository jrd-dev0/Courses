package aula91_Ex2;

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
		
		double soma = 0;
		
		System.out.printf("VALORES = ");
		for(double num : numeros) {
			System.out.printf("%.1f ", num);
			soma += num;
		}
		
		double media = soma / numeros.length;
		
		System.out.println();
		System.out.printf("SOMA = %.2f%n", soma);
		System.out.printf("MEDIA = %.2f%n", media);
		
		sc.close();
	}

}
