 package application;

import java.io.BufferedReader;
import java.io.FileReader;
import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;
import java.util.Locale;
import java.util.Scanner;
// import java.util.stream.Collectors;

import entitites.Product;

public class Program {

	public static void main(String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		System.out.printf("Enter full file path: ");
		String filePath = sc.nextLine();
		//String filePath = "C:\\Temp\\in.txt";
		
		List<Product> productList = new ArrayList<Product>();
		
		try(BufferedReader br = new BufferedReader(new FileReader(filePath))){
			
			String line = br.readLine();
			
			while(line != null){
                
				String[] st = line.split(",");
				productList.add(new Product(st[0], Double.parseDouble(st[1])));
                line = br.readLine();
            }
			
			double averagePrice = productList.stream()
					.mapToDouble(Product::getPrice)
					.average()
					.orElse(0.0);
			
			/*
			 * double avgPrice = productList.stream()
			 * .map(p -> p.getPrice()) //obter apenas os preços
			 * .reduce(0.0, (x,y) -> x + y / productList.size()); // função que soma os preços e divide pelo tamanho da lista
			 */
			System.out.printf("Average price: %.2f%n", averagePrice);
			
			productList.stream()
					.filter(product -> product.getPrice() < averagePrice)
					.sorted(Comparator.comparing(Product::getName)
					.reversed())
					.forEach(product -> System.out.println(product.getName()));
			
			/*
			 * Comparator<String> comp = (s1, s2) ->
			 * s1.toUpperCase().compareTo(s2.toUpperCase());
			 * 
			 * List<String> names = productList.stream()
			 * .filter(p -> p.getPrice() < averagePrice)
			 * .map(p -> p.getName())
			 * .sorted(comp.reversed())
			 * .collect(Collectors.toList());
			 * 
			 * names.forEach(System.out::println);
			 */
			
		}
		
		catch(Exception e){
            System.out.println("Error reading file: " + e.getMessage());
        }
		
		finally {
			sc.close();
		}
	}
}