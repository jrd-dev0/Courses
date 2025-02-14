package aula70_Ex1;

import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		Rectangle rectangle = new Rectangle();
		
		System.out.println("Enter rectangle width and height:");
		System.out.printf("Width: ");
		rectangle.Width = sc.nextDouble();
		System.out.printf("Height: ");
		rectangle.Height = sc.nextDouble();
		
		System.out.printf("AREA = %.2f%n", rectangle.Area());
		System.out.printf("PERIMETER = %.2f%n", rectangle.Perimeter());
		System.out.printf("Diagonal = %.2f%n", rectangle.Diagonal());
		
		sc.close();
		
	}
}