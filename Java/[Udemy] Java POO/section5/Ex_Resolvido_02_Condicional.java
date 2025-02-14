package sessao6;
import java.util.Scanner;

public class Ex_Resolvido_02_Condicional {

    public static void main(String[] args){

        System.out.println("Fazer um programa para ler três números inteiro.");
        System.out.println("Em seguida, mostrar qual o menor dentre os três números lidos.");

        Scanner sc = new Scanner(System.in);

        String[] numeros = sc.nextLine().split(" ");
        int a = Integer.parseInt(numeros[0]);
        int b = Integer.parseInt(numeros[1]);
        int c = Integer.parseInt(numeros[2]);

        int menor;

        if(a < b && a < c){
            menor = a;
        } else if(b < c){
            menor = b;
        } else {
            menor = c;
        }

        System.out.println("MENOR = " + menor);

        sc.close();
    }
}
