import java.util.Locale;
import java.util.Scanner;

public class BEE1013 {

    public static void main(String[] args) {
        
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        String[] valores = sc.nextLine().split(" ");
        int a = Integer.parseInt(valores[0]);
        int b = Integer.parseInt(valores[1]);
        int c = Integer.parseInt(valores[2]);

        int maiorAB = (a + b + Math.abs(a - b)) / 2;
        int maiorABC = (maiorAB + c + Math.abs(maiorAB - c)) / 2;

        System.out.println(maiorABC + " eh o maior");

        sc.close();
    }
}