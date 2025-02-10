package application;

import java.time.LocalDate;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.util.Locale;
import java.util.Scanner;

import entities.Client;
import entities.Order;
import entities.OrderItem;
import entities.Product;
import entities.enums.OrderStatus;

public class Program {

	public static void main(String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		System.out.println("Enter client data:");
		System.out.print("Name: ");
		String name = sc.nextLine();
		System.out.print("Email: ");
		String email = sc.nextLine();
		System.out.print("Bird data (DD/MM/YYYY): ");
		LocalDate birthDate = LocalDate.parse(sc.nextLine(), DateTimeFormatter.ofPattern("dd/MM/yyyy"));
		
		Client client = new Client(name, email, birthDate);
		
		System.out.println();
		System.out.println("Enter Order data:");
		System.out.print("Status: ");
		OrderStatus status = OrderStatus.valueOf(sc.nextLine());
		
		System.out.println();
		System.out.print("How many items to this order? ");
		int n = sc.nextInt();
		sc.nextLine();
		
		Order order = new Order(client, LocalDateTime.now(), status);
		
		for(int i = 0; i < n; i++) {
			System.out.printf("Enter #%d item data:%n", i + 1);
            System.out.print("Product name: ");
            String productName = sc.nextLine();
            System.out.print("Product Price: ");
            double productPrice = sc.nextDouble();
            System.out.print("Quantity: ");
            int quantity = sc.nextInt();
            System.out.println("------------------------------");
            sc.nextLine();
            
            order.addItem(new OrderItem(new Product(productName, productPrice), quantity));
		}
		
		System.out.println("ORDER SUMMARY:");
		System.out.println(order);
		
		sc.close();

	}
}