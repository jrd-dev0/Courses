package aula91_Ex4;

import java.util.Scanner;

public class Program {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		System.out.printf("Quantos numeros voce vai digitar? ");
		int n = sc.nextInt();
		
		int[] numeros = new int[n];
		
		for (int i = 0; i < n; i++) {
			
			System.out.printf("Digite um numero: ");
			numeros[i] = sc.nextInt();
		}
		
		int quantidadeDePares = 0;
		
		System.out.println();
		System.out.println("NUMEROS PARES:");
		for(int i : numeros) {
			
			if(i % 2 == 0) {
				System.out.printf("%d ", i);
				quantidadeDePares++;
			}
		}
		
		System.out.printf("%n%n");
		System.out.printf("QUANTIDADE DE PARES = %d", quantidadeDePares);
		sc.close();
	}

}
