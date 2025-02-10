import java.util.Scanner;

public class BEE1044 {

    public static void main(String[] args) {
        
        Scanner sc = new Scanner(System.in);

        String[] entrada = sc.nextLine().split(" ");
        int a = Integer.parseInt(entrada[0]);
        int b = Integer.parseInt(entrada[1]);

        if (a % b == 0 || b % a == 0) {
            System.out.println("Sao Multiplos");
        } else {
            System.out.println("Nao sao Multiplos");
        }

        sc.close();
    }
}
