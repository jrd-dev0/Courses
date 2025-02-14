package model.services;

public class BrazilTaxService implements TaxService {

    //lógica de cálculo de imposto (20% até 100.00, 15% acima)
    public Double tax(Double amount) {
        if (amount <= 100.0) {
            return amount * 0.2;
        } else {
            return amount * 0.15;
        }
    }
}