package application;

import java.io.BufferedReader;
import java.io.FileReader;
import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;
import java.util.Locale;
import java.util.Scanner;
import entities.Employee;

public class Program {

	public static void main(String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		List<Employee> list = new ArrayList<>();
		
		System.out.print("Enter full file path: ");
		String filePath = sc.nextLine();
		
		try(BufferedReader br = new BufferedReader(new FileReader(filePath))){
			
			String line = br.readLine();
			
			while(line!= null) {
				String[] fields = line.split(",");
                list.add(new Employee(fields[0], fields[1], Double.parseDouble(fields[2])));
                line = br.readLine();
			}
			
			//continua no prox. episodio
			
			System.out.println("Email of people whose salary is more than 2000.00:");
			list.stream()
			    .filter(e -> e.getSalary() > 2000.00)
			    .sorted(Comparator.comparing(Employee::getName))
                .forEach(e -> System.out.println(e.getEmail()));
			
			double sumSalary = list.stream()
					.filter(e -> e.getName().charAt(0) == 'M')
					.mapToDouble(Employee::getSalary)
                    .sum();
			
			System.out.printf("Sum of salary of people whose name starts with 'M': %.2f", sumSalary);
						
		}
		catch(Exception e) {
			System.out.println("Error: " + e);
		}
		finally {
			sc.close();
		}

	}
}