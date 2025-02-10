import java.util.Locale;
import java.util.Scanner;

public class BEE1036 {

    public static void main(String[] args) {
        
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        String[] valores = sc.nextLine().split(" ");
        double a = Double.parseDouble(valores[0]);
        double b = Double.parseDouble(valores[1]);
        double c = Double.parseDouble(valores[2]);

        double delta = Math.pow(b, 2.0) - 4 * a * c;

        if (a == 0 || delta < 0) {
            System.out.println("Impossivel calcular");
        } else {
            double r1 = (-b + Math.sqrt(delta)) / (2 * a);
            double r2 = (-b - Math.sqrt(delta)) / (2 * a);
            System.out.printf("R1 = %.5f%n", r1);
            System.out.printf("R2 = %.5f%n", r2);
        }

        sc.close();
    }

}
