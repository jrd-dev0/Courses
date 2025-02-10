import java.util.Locale;
import java.util.Scanner;

public class BEE1040 {

    public static void main(String[] args) {
        
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        String[] notas = sc.nextLine().split(" ");
        float nota1 = Float.parseFloat(notas[0]);
        float nota2 = Float.parseFloat(notas[1]);
        float nota3 = Float.parseFloat(notas[2]);
        float nota4 = Float.parseFloat(notas[3]);

        double media = (nota1 * 2 + nota2 * 3 + nota3 * 4 + nota4) / 10;

        System.out.printf("Media: %.1f\n", media);

        if(media >= 7.0) {
            System.out.println("Aluno aprovado.");
        } else if(media < 5.0) {
            System.out.println("Aluno reprovado.");
        } else {
            System.out.println("Aluno em exame.");
            double notaExame = Double.parseDouble(sc.nextLine());
            System.out.printf("Nota do exame: %.1f%n", notaExame);
            media = (media + notaExame) / 2;
            if(media >= 5.0){
                System.out.println("Aluno aprovado.");
            } else {
                System.out.println("Aluno reprovado.");
            }
            System.out.printf("Media final: %.1f%n", media);
        }
        sc.close();
    }
}
