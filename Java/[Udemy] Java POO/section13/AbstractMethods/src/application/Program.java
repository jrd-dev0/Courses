package application;

import java.util.ArrayList;
import java.util.List;
import java.util.Locale;
import java.util.Scanner;

import entities.Circle;
import entities.Rectangle;
import entities.Shape;
import entities.enums.Color;

public class Program {

	public static void main(String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		List<Shape> list = new ArrayList<>();
		
		System.out.print("Enter the number of shapes: ");
		int n = sc.nextInt();
		sc.nextLine();
		
		System.out.println();
		for(int i = 0; i < n; i++) {
			
			System.out.printf("Shape #%d data:%n", i + 1);
			System.out.print("rectangle or Circle (r/c)? ");
			char shape = sc.next().charAt(0);
			sc.nextLine();
			System.out.print("COLOR (BLACK/BLUE/RED): ");
			Color color = Color.valueOf(sc.nextLine());
			
            if(shape == 'r') {
            	
            	System.out.print("Widht: ");
            	double width = sc.nextDouble();
            	System.out.print("Height: ");
            	double height = sc.nextDouble();
            	
            	list.add(new Rectangle(color, width, height));
            }
            else {
            	
                System.out.print("Radius: ");
                double radius = sc.nextDouble();
                
                list.add(new Circle(color, radius));
            }
		}

		sc.close();
		
		System.out.println("SHAPE AREAS:");
		
		for(Shape shape : list) {
            System.out.printf("%.2f%n", shape.area());
        }
	}

}
