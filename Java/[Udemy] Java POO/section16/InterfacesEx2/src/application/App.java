package application;

import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.util.Locale;
import java.util.Scanner;

import models.entities.Contract;
import models.services.ContractService;
import models.services.PaypalService;

public class App {
    public static void main(String[] args) throws Exception {
        
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        System.out.println("Enter contract data:");
        System.out.print("Number: ");
        int number = sc.nextInt();
        sc.nextLine();
        System.out.print("Date (dd/MM/yyyy): ");
        LocalDate date = LocalDate.parse(sc.nextLine(), DateTimeFormatter.ofPattern("dd/MM/yyyy"));
        System.out.print("Contract value: ");
        double value = sc.nextDouble();
        System.out.print("Enter number of installments: ");
        int months = sc.nextInt();
        sc.nextLine();

        Contract contract = new Contract(number, date, value);
        ContractService contractService = new ContractService(new PaypalService());

        contractService.processContract(contract, months);

        System.out.println("Installments:");
        for (int i = 0; i < contract.getInstallments().size(); i++) {
            System.out.println(contract.getInstallments().get(i));
        }

        sc.close();
    }
}
