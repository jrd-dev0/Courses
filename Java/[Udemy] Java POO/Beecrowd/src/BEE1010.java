import java.util.Locale;
import java.util.Scanner;

public class BEE1010 {
    public static void main(String[] args) {

        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        String[] peca1 = sc.nextLine().split(" ");
        int codPeca1 = Integer.parseInt(peca1[0]);
        int numPeca1 = Integer.parseInt(peca1[1]);
        double valorPeca1 = Double.parseDouble(peca1[2]);

        String[] peca2 = sc.nextLine().split(" ");
        int codPeca2 = Integer.parseInt(peca2[0]);
        int numPeca2 = Integer.parseInt(peca2[1]);
        double valorPeca2 = Double.parseDouble(peca2[2]);

        double total = numPeca1 * valorPeca1 + numPeca2 * valorPeca2;

        System.out.printf("VALOR A PAGAR: R$ %.2f%n", total);
        sc.close();
    }
}