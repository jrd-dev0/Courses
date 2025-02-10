import java.util.Locale;
import java.util.Scanner;

public class BEE1045 {

    public static void main(String[] args) {
        
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        String[] valores = sc.nextLine().split(" ");
        double a = Double.parseDouble(valores[0]);
        double b = Double.parseDouble(valores[1]);
        double c = Double.parseDouble(valores[2]);

        double A = Math.max(a, Math.max(b, c));
        double B = Math.min(a, Math.min(b, c));
        double C = a + b + c - A - B;

        if (A >= B + C) {
            System.out.println("NAO FORMA TRIANGULO");
        } else {
            if (Math.pow(A, 2) == Math.pow(B, 2) + Math.pow(C, 2)) {
                System.out.println("TRIANGULO RETANGULO");
            }
            else if (Math.pow(A, 2) > Math.pow(B, 2) + Math.pow(C, 2)) {
                System.out.println("TRIANGULO OBTUSANGULO");
            }
            else {
                System.out.println("TRIANGULO ACUTANGULO");
            }
            if (A == B && A == C) {
                System.out.println("TRIANGULO EQUILATERO");
            } else if (A == B || A == C || B == C ) {
                System.out.println("TRIANGULO ISOSCELES");
            }
        }

        sc.close();
    }
}