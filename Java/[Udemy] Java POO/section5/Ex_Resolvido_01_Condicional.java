package sessao6;
import java.util.Locale;
import java.util.Scanner;

public class Ex_Resolvido_01_Condicional {

    public static void main(String[] args){

        System.out.println("Esse programa deve ler as duas notas que um aluno obteve no primeiro e segundo semestres de uma disciplina anual.");
        System.out.println("Em seguida, mostrar a nota final que o aluno obteve no ano juntamente com um texto explicativo.");
        System.out.println("Caso a nota final seja inferior a 60.00, o programa deve mostrar uma mensagem: 'REPROVADO'.");
        System.out.println("Todos os valores devem ter uma casa decimal.");

        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);
        
        double nota1 = sc.nextDouble();
        double nota2 = sc.nextDouble();

        double notaFinal = nota1 + nota2;

        System.out.printf("NOTA FINAL = %.1f%n", notaFinal);
        if(notaFinal < 60.0){
            System.out.println("REPROVADO");
        }

        sc.close();
    }
}
