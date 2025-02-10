package aula64;

import java.util.Locale;
import java.util.Scanner;

public class SolvingProblemWithOO {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);

		Triangle x = new Triangle();
		Triangle y = new Triangle();
		
		System.out.println("Enter the measures of triagle X:");
		x.a = sc.nextDouble();
		x.b = sc.nextDouble();
		x.c = sc.nextDouble();
		
		System.out.println("Enter the measures of triagle Y:");
		y.a = sc.nextDouble();
		y.b = sc.nextDouble();
		y.c = sc.nextDouble();

		System.out.printf("Triangle X area: %.4f%n", x.Area());
		System.out.printf("Triangle Y area: %.4f%n", y.Area());

		if (x.Area() > y.Area()) {
			System.out.println("Large area: X");
		} else {
			System.out.println("Large area: Y");
		}
		
		sc.close();

	}

}