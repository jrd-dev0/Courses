package aula70_Ex2;

import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		Employee employee = new Employee();
		
		System.out.printf("Name: ");
		employee.Name = sc.nextLine();		
		System.out.printf("Gross Salary: ");
		employee.GrossSalary = sc.nextDouble();
		System.out.printf("Tax: ");
		employee.Tax = sc.nextDouble();
		
		System.out.println("Employee: " + employee);
		
		System.out.printf("Which percentage to increase salary? ");
		employee.IncreaseSalary(sc.nextDouble());
		
		System.out.println("updated data: " + employee);
		
		sc.close();
	}
}