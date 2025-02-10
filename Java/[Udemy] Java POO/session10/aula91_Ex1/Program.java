package aula91_Ex1;

import java.util.Scanner;

public class Program {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);		
		
		System.out.printf("Quantos numeros voce vai digitar? ");
		int quantosNumeros = sc.nextInt();
		
		int[] numeros = new int[quantosNumeros];
		
		for(int i = 0; i < quantosNumeros; i++) {
			
			System.out.printf("Digite um numero: ");
			int num = sc.nextInt();
			
			numeros[i] = num;			
		}
		
		System.out.println("NUMEROS NEGATIVOS:");
		for (int i : numeros) {
			if (i < 0) {
				System.out.println(i);
			}			
		}
		
		sc.close();
	}
}
