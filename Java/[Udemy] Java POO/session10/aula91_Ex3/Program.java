package aula91_Ex3;

import java.util.Locale;
import java.util.Scanner;

public class Program {

	public static void main(String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		System.out.printf("Quantas pessoas serao digitadas? ");
		int n = sc.nextInt();
		sc.nextLine();
		
		People[] peoples = new People[n];
		
		for(int i = 0; i < n; i++) {
			
			System.out.printf("Dados da %da pessoa:%n", i+1);
			System.out.printf("Nome: ");
			String name = sc.nextLine();
			System.out.printf("Idade: ");
			int age = sc.nextInt();
			System.out.printf("Altura: ");
			double height = sc.nextDouble();
			sc.nextLine();
			peoples[i] = new People(name, age, height);
		}
		
		System.out.printf("Altura média: %.2f%n", People.averageHeight(peoples));
		System.out.printf("Pessoas com menos de 16 anos: %.1f%%%n", People.percentageOfPeopleUnder16(peoples));
		People.nameOfPeopleUnder16(peoples);
	
		sc.close();
	}
}