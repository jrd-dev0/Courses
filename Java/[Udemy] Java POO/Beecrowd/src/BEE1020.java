import java.util.Scanner;

public class BEE1020 {

    public static void main(String[] args) {
        
        Scanner sc = new Scanner(System.in);

        int IdadeEmDias = sc.nextInt();

        int anos = IdadeEmDias / 365;
        IdadeEmDias %= 365;
        int meses = IdadeEmDias / 30;
        IdadeEmDias %= 30;

        System.out.println(anos + " ano(s)");
        System.out.println(meses + " mes(es)");
        System.out.println(IdadeEmDias + " dia(s)");

        sc.close();
    }
}