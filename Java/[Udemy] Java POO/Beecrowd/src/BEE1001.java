import java.util.Locale;
import java.util.Scanner;

public class BEE1001 {
    public static void main(String[] args) throws Exception {
    
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        int a = sc.nextInt();
        int b = sc.nextInt();
        sc.close();

        int soma = a + b;
        System.out.println("X = " + soma);
        
    }
}