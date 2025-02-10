package aula70_Ex3;

import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		Student student = new Student();		
		student.Name = sc.nextLine();
		student.Score1 = sc.nextDouble();
		student.Score2 = sc.nextDouble();
		student.Score3 = sc.nextDouble();
		
		System.out.printf("FINAL GRADE = %.2f%n", student.FinalGrade());
		
		if (student.FinalGrade() >= 60.0) {
			System.out.println("PASS");
		}
		else {
			System.out.println("FAILED");			
			System.out.printf("MISSING %.2f POINTS", student.MissingPoints());
		}
		
		sc.close();
	}
}
