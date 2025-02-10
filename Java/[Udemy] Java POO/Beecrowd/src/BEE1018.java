import java.util.Scanner;

public class BEE1018 {

    public static void main(String[] args) {
     
       Scanner sc = new Scanner(System.in);
       
       int n = sc.nextInt();
       
       System.out.println(n);

       int cem = n / 100;
       n %= 100;
       int cinquenta = n / 50;
       n %= 50;
       int vinte = n / 20;
       n %= 20;
       int dez = n / 10;
       n %= 10;
       int cinco = n / 5;
       n %= 5;
       int dois = n / 2;
       n %= 2;
       int um = n;
       
       System.out.println(cem + " nota(s) de R$ 100,00");
       System.out.println(cinquenta + " nota(s) de R$ 50,00");
       System.out.println(vinte + " nota(s) de R$ 20,00");
       System.out.println(dez + " nota(s) de R$ 10,00");
       System.out.println(cinco + " nota(s) de R$ 5,00");
       System.out.println(dois + " nota(s) de R$ 2,00");
       System.out.println(um + " nota(s) de R$ 1,00");
       
       sc.close();
    }
}