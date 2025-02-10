import java.util.Locale;
import java.util.Scanner;

public class BEE1043 {

    public static void main(String[] args) {
        
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        String[] entrada = sc.nextLine().split(" ");
        double a = Double.parseDouble(entrada[0]);
        double b = Double.parseDouble(entrada[1]);
        double c = Double.parseDouble(entrada[2]);

        if(a + b > c && a + c > b && b + c > a){
            System.out.printf("Perimetro = %.1f%n", a + b + c);
        } else {
            double area = ((a + b) * c) / 2;
            System.out.printf("Area = %.1f%n", area);
        }

        sc.close();
    }
}