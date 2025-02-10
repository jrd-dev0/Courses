import java.util.Locale;
import java.util.Scanner;

public class BEE1016 {

    public static void main(String[] args) {
     
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        int distancia = sc.nextInt();

        int tempo = distancia * 2;

        System.out.println(tempo + " minutos");

        sc.close();
    }
}
