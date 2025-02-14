// Exercicio Curso Udemy - 16.Saída de dados.
package sessao6;

import java.util.Locale;    // Importação da biblioteca Locale.

public class Ex_Fixacao_1 {
    public static void main(String[] args) {
        String product1 = "Computer";
        String product2 = "Office desk";

        int age = 30;
        int code = 5290;
        char gender = 'F';

        double price1 = 2100.0;
        double price2 = 650.50;
        double measure = 53.234567;

        System.out.println("Products:");
        System.out.printf("%s, which price is $ %.2f%n", product1, price1);
        System.out.printf("%s, which price is $ %.2f%n", product2, price2);
        System.out.println();
        System.out.printf("Record: %d years old, code %d and gender: %s%n", age, code, gender);
        System.out.println();
        System.out.println("Measue with eithg decimal places: " + measure);
        System.out.printf("Rouded (three decimal places): %.3f%n", measure);

        Locale.setDefault(Locale.US);    // Definindo o padrão de impressão para US.
        System.out.printf("US decimal point: %.3f%n", measure);
    }
}
