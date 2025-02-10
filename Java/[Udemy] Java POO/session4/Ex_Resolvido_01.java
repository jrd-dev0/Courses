package sessao6;
import java.util.Locale;
import java.util.Scanner;

public class Ex_Resolvido_01 {
    public static void main(String[] args) {
        System.out.println("Esse programa deve ler as medidas da largura e comprimento de um terreno retangular com uma casa decimal,");
        System.out.println("bem como o valor do metro quadrado do terreno cm duas casas decimais.");
        System.out.println("Em seguida, o programa deve mostrar o valor da área do terreno,");
        System.out.println("bem como o valor do preço do terreno, ambos com duas casas decimais.");
        
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);
        
        System.out.println("Informe as medidas do terreno:");
        System.out.printf("Largura: ");
        double largura = sc.nextDouble();
        System.out.printf("Comprimento: ");
        double comprimento = sc.nextDouble();
        System.out.printf("Valor do metro quadrado: ");
        double metroQuadrado = sc.nextDouble();
        sc.close();

        double area = largura * comprimento;
        double precoTerreno = area * metroQuadrado;
        
        System.out.printf("AREA = %.2f%n", area);
        System.out.printf("PRECO = %.2f%n", precoTerreno);
    }
}