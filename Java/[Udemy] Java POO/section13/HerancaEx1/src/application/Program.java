package application;

import java.util.ArrayList;
import java.util.List;
import java.util.Locale;
import java.util.Scanner;

import entities.Employee;
import entities.OutsourcedEmployee;

public class Program {

	public static void main(String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		List<Employee> list = new ArrayList<>();
		
		System.out.print("Enter the number of employees: ");
		int n = sc.nextInt();
		
		for(int i = 0; i < n; i++) {
			
			System.out.printf("Employee #%d data:%n", i + 1);
			
			System.out.print("Outsourced (y/n)? ");
			char outsourced = sc.next().charAt(0);
			sc.nextLine();
            System.out.print("Name: ");
            String name = sc.nextLine();
            System.out.print("Hours: ");
            int hours = sc.nextInt();
            System.out.print("Salary: ");
            double salary = sc.nextDouble();
            
            if(outsourced == 'y') {
            	System.out.print("Additional Charge: ");
                double additionalCharge = sc.nextDouble();
            	list.add(new OutsourcedEmployee(name, hours, salary, additionalCharge));
            }
            else {
            	list.add(new Employee(name, hours, salary));
            }
		}
		
		System.out.println("PAYMENTS:");
		for(Employee e : list) {
			System.out.println(e);
		}
		
		sc.close();
	}
}