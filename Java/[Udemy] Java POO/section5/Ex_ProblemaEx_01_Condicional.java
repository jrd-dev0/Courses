package sessao6;
import java.util.Locale;
import java.util.Scanner;

public class Ex_ProblemaEx_01_Condicional {

    public static void main(String[] args){

        System.out.println("Uma operadora de telefonia cobra R$ 50.00 por um plano básico que dá direito a 100 minutos de telefone.");
        System.out.println("Cada minuto que exceder a franquia de 100 minutos custa R$ 2.00.");
        System.out.println("Fazer um programa para ler a quantidade de minutos que uma pessoa consumiu, daí mostrar o valor a ser pago.");

        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        int minutos = sc.nextInt();

        double conta = 50.0;

        if(minutos > 100){
            conta += (minutos - 100) * 2.0;

        }

        System.out.printf("VALOR A PAGAR: R$ %.2f%n", conta);

        sc.close();
    }

}
