import java.util.Locale;
import java.util.Scanner;

public class BEE1042 {

    public static void main(String[] args){

        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        String[] entrada = sc.nextLine().split(" ");
        int a = Integer.parseInt(entrada[0]);
        int b = Integer.parseInt(entrada[1]);
        int c = Integer.parseInt(entrada[2]);

        int menor = a;
        int meio = b;
        int maior = c;

        if (a > b && a > c) {
            maior = a;
            if (b > c) {
                meio = b;
                menor = c;
            } else {
                meio = c;
                menor = b;
            }
        } else if (b > a && b > c) {
            maior = b;
            if (a > c) {
                meio = a;
                menor = c;
            } else {
                meio = c;
                menor = a;
            }
        } else {
            maior = c;
            if (a > b) {
                meio = a;
                menor = b;
            } else {
                meio = b;
                menor = a;
            }
        }

        System.out.println(menor);
        System.out.println(meio);
        System.out.println(maior);
        System.out.println();
        System.out.println(a);
        System.out.println(b);
        System.out.println(c);

        sc.close();
                
    }

}
