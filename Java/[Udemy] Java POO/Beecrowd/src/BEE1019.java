import java.util.Locale;
import java.util.Scanner;

public class BEE1019 {

    public static void main(String[] args) {
        
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        int segundos = sc.nextInt();

        int horas = segundos / 3600;
        segundos %= 3600;
        int minutos = segundos / 60;
        segundos %= 60;

        System.out.printf("%d:%d:%d%n", horas, minutos, segundos);

        sc.close();
    }
}
