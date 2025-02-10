import java.util.Locale;
import java.util.Scanner;

public class BEE1012 {

    public static void main(String[] args) {
        
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        String[] valores = sc.nextLine().split(" ");
        double a = Double.parseDouble(valores[0]);
        double b = Double.parseDouble(valores[1]);
        double c = Double.parseDouble(valores[2]);

        double triangulo = Triangulo(a, c);
        double circulo = Circulo(c);
        double trapezio = Trapezio(a, b, c);
        double quadrado = Quadrado(b);
        double retangulo = Retangulo(a, b);

        System.out.printf("TRIANGULO: %.3f\n", triangulo);
        System.out.printf("CIRCULO: %.3f\n", circulo);
        System.out.printf("TRAPEZIO: %.3f\n", trapezio);
        System.out.printf("QUADRADO: %.3f\n", quadrado);
        System.out.printf("RETANGULO: %.3f\n", retangulo);

        sc.close();
    }

    public static double Triangulo(double base, double altura) {
        return (base * altura) / 2;
    }
    
    public static double Circulo(double raio) {
        return 3.14159 * Math.pow(raio, 2);
    }
    
    public static double Trapezio(double baseMaior, double baseMenor, double altura) {
        return ((baseMaior + baseMenor) * altura) / 2;
    }

    public static double Quadrado(double lado) {
        return Math.pow(lado, 2);
    }

    public static double Retangulo(double base, double altura) {
        return base * altura;
    }
}
