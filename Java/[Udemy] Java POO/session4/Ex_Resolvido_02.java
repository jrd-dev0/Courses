package sessao6;
import java.util.Locale;
import java.util.Scanner;

public class Ex_Resolvido_02 {

    public static void main(String[] args) {
        System.out.println("Esse programa deve ler as medidas da base e altura de um retângulo.");
        System.out.println("Em seguida, mostrar o valor da área, perímetro e diagonal desse retângulo, com 4 casas decimais.");
        
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);
        
        System.out.println("Informe as medidas do retângulo:");
        System.out.printf("Base: ");
        double base = sc.nextDouble();
        System.out.printf("Altura: ");
        double altura = sc.nextDouble();

        double area = base * altura;
        double perimetro = 2 * (base + altura);
        double diagonal = Math.sqrt(Math.pow(base, 2) + Math.pow(altura, 2));

        System.out.printf("AREA = %.4f%n", area);
        System.out.printf("PERIMETRO = %.4f%n", perimetro);
        System.out.printf("DIAGONAL = %.4f%n", diagonal);

        sc.close();
    }
}