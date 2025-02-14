package aula64;

import java.util.Locale;
import java.util.Scanner;

public class SolvingProblemWithoutOO {

	public static void main(String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		System.out.println("Enter the measures of triagle X:");
		double xa = sc.nextDouble();
		double xb = sc.nextDouble();
		double xc = sc.nextDouble();
		
		System.out.println("Enter the measures of triagle Y:");
		double ya = sc.nextDouble();
		double yb = sc.nextDouble();
		double yc = sc.nextDouble();
		
		sc.close();
		
		double xp = (xa + xb + xc) / 2;
		double yp = (ya + yb + yc) / 2;
		
		double areaX = Math.sqrt(xp * (xp - xa) * (xp - xb) * (xp - xc));
		double areaY = Math.sqrt(yp * (yp - ya) * (yp - yb) * (yp - yc));
		
		System.out.printf("Triangle X area: %.4f%n", areaX);
		System.out.printf("Triangle Y area: %.4f%n", areaY);
		
		if (areaX > areaY) {
			System.out.println("Large area: X");
		}
		else {
			System.out.println("Large area: Y");
		}

	}

}
