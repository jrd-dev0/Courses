/* Fazer um programa para ler os dados de um produto em estoque (nome, preço e quantidade no estoque). Em seguida:
 * - Mostrar os dados do produto (nome, preço, quantidade no estoque, valor total no estoque)
 * - Realizar uma entrada no estoque e mostrar novamente os dados do produto
 * - Realizar uma saída no estoque e mostrar novamente os dados do produto
 */

package aula67;

import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		Product product = new Product();
		System.out.println("Enter product data:");
		System.out.printf("Name: ");
		product.Name = sc.next();
		System.out.printf("Price: ");
		product.Price = sc.nextDouble();
		System.out.printf("Quantity in stock: ");
		product.Quantity = sc.nextInt();
		
		System.out.println("Product data: " + product);
		
		System.out.printf("Enter the number of products to be added in stock: ");
		product.AddProduct(sc.nextInt());
		
		System.out.println("Updated data: " + product);

		System.out.printf("Enter the number of products to be removed from stock: ");
		product.RemoveProduct(sc.nextInt());
		
		System.out.println("Updated data: " + product);

		sc.close();
	}

}
