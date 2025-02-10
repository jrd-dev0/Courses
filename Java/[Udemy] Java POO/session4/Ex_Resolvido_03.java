package sessao6;
import java.util.Locale;
import java.util.Scanner;

public class Ex_Resolvido_03 {

    public static void main(String[] args) {
        System.out.println("Esse programa deve ler o nome (apenas uma palavra) e idade de duas pessoas.");
        System.out.println("Ao final, mostrar uma mensagem com os nomes e a idade média entre essas pessoas, com uma casa decimal.");
        
        Locale.setDefault(java.util.Locale.US);
        Scanner sc = new java.util.Scanner(System.in);
        
        System.out.printf("Informe o nome e a idade da primeira pessoa: ");
        String[] pessoa1 = sc.nextLine().split(" ");
        String nome1 = pessoa1[0];
        int idade1 = Integer.parseInt(pessoa1[1]);

        System.out.printf("Informe o nome e a idade da segunda pessoa: ");
        String[] pessoa2 = sc.nextLine().split(" ");
        String nome2 = pessoa2[0];
        int idade2 = Integer.parseInt(pessoa2[1]);

        double mediaIdade = (idade1 + idade2) / 2.0;
        
        System.out.printf("A idade média de %s e %s é de %.1f anos%n", nome1, nome2, mediaIdade);

        sc.close();
    }

}
