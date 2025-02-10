import java.util.Locale;
import java.util.Scanner;

public class BEE1015 {

    public static void main(String[] args) {
        
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        String[] valores1 = sc.nextLine().split(" ");
        double x1 = Double.parseDouble(valores1[0]);
        double y1 = Double.parseDouble(valores1[1]);

        String[] valores2 = sc.nextLine().split(" ");
        double x2 = Double.parseDouble(valores2[0]);
        double y2 = Double.parseDouble(valores2[1]);

        double distancia = Math.sqrt(Math.pow(x2 - x1, 2) + Math.pow(y2 - y1, 2));

        System.out.printf("%.4f\n", distancia);

        sc.close();
    }
}