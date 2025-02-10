import java.util.Locale;
import java.util.Scanner;

public class BEE1002 {
    public static void main(String[] args) {
        
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        double r = sc.nextDouble();
        double area = 3.14159 * Math.pow(r, 2);

        System.out.printf("A=%.4f%n", area);
        sc.close();
    }

}
