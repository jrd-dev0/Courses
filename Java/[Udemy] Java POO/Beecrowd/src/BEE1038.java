import java.util.Locale;
import java.util.Scanner;

public class BEE1038 {

    public static void main(String[] args) {
        
        System.out.println("_______________________________________");
        System.out.println("  CODIGO    ESPECIFICAÇÃO     PREÇO    ");
        System.out.println("_______________________________________");
        System.out.println("     1      Cachorro Quente    R$ 4.00 ");
        System.out.println("     2      X-Salada           R$ 4.50 ");
        System.out.println("     3      X-Bacon            R$ 5.00 ");
        System.out.println("     4      Torrada Simples    R$ 2.00 ");
        System.out.println("     5      Refrigerante       R$ 1.50 ");
        System.out.println("_______________________________________");
        System.out.println();
        System.out.printf("Digite o código do produto e a quantidade desejada: ");
        
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);
        String[] entrada = sc.nextLine().split(" ");
        int codigo = Integer.parseInt(entrada[0]);
        int quantidade = Integer.parseInt(entrada[1]);

        double total = 0;

        switch (codigo) {
            case 1:
                total = 4.00 * quantidade;
                break;
            case 2:
                total = 4.50 * quantidade;
                break;
            case 3:
                total = 5.00 * quantidade;
                break;
            case 4:
                total = 2.00 * quantidade;
                break;
            case 5:
                total = 1.50 * quantidade;
                break;
            default:
                break;
        }

        System.out.printf("Total: R$ %.2f\n", total);

        sc.close();
    }

}
