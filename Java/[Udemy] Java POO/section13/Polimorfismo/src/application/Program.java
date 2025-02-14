package application;

import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.util.ArrayList;
import java.util.List;
import java.util.Locale;
import java.util.Scanner;

import entities.ImportedProduct;
import entities.Product;
import entities.UsedProduct;

public class Program {

	public static void main(String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		List<Product> products = new ArrayList<>();
		
		System.out.print("Enter the number of products: ");
		int n = sc.nextInt();
		sc.nextLine();
		System.out.println();
		for(int i =0; i < n; i++) {
			
			System.out.printf("Product #%d data:%n", i + 1);
			System.out.print("Common, used or imported (c/u/i)? ");
			char type = sc.next().charAt(0);
			sc.nextLine();
            System.out.print("Name: ");
            String name = sc.nextLine();
            System.out.print("Price: ");
            double price = sc.nextDouble();
            sc.nextLine();
            if(type == 'c') {
            	
            	products.add(new Product(name, price));
            	
            } else if (type == 'u') {
            	
            	System.out.print("Manufacture Date (DD/MM/YYYY): ");
            	LocalDate manufactureDate = LocalDate.parse(sc.nextLine(), DateTimeFormatter.ofPattern("dd/MM/yyyy"));
            	products.add(new UsedProduct(name, price, manufactureDate));
            	
            } else {
            	
            	System.out.print("Custom fee: ");
            	double customFee = sc.nextDouble();
            	products.add(new ImportedProduct(name, price, customFee));
            }
            
            System.out.println();
		}
		
		System.out.println("PRICE TAGS:");
		
		for(Product p : products) {
			System.out.println(p.priceTag());
		}
		
		sc.close();
	}
}