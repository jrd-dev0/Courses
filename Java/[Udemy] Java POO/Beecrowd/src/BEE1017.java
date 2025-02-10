import java.util.Locale;
import java.util.Scanner;

public class BEE1017 {

    public static void main(String[] args) {
        
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        double tempo = sc.nextDouble();
        double velocidade = sc.nextDouble();

        double distancia = Distancia(tempo, velocidade);
        
        System.out.printf("%.3f%n", distancia);
        sc.close();
    }

    public static double Distancia(double tempo, double velocidade) {
        return (tempo * velocidade) / 12;
    }
}
