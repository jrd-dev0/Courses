import java.util.Locale;
import java.util.Scanner;

public class BEE1008 {
    public static void main(String[] args) {
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        int number = sc.nextInt();
        int hoursWorked = sc.nextInt();
        double salaryHour = sc.nextDouble();

        double salaryTotal = hoursWorked * salaryHour;

        System.out.println("NUMBER = " + number);
        System.out.printf("SALARY = U$ %.2f%n", salaryTotal);
        sc.close();
    }
}
