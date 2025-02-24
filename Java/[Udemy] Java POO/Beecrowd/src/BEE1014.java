import java.util.Locale;
import java.util.Scanner;

public class BEE1014 {

    public static void main(String[] args) {
        
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        int x = sc.nextInt();
        double y = sc.nextDouble();

        double consumo = Consumo(x, y);

        System.out.printf("%.3f km/l%n", consumo);

        sc.close();
    }

    public static double Consumo(int distancia, double combustivel) {
        return distancia / combustivel;
    }
}