package models.entities;

import java.time.LocalDate;
import java.time.format.DateTimeFormatter;

public class Installment {

    private Double amount;
    private LocalDate dueDate;

    public Installment(Double amount, LocalDate dueDate) {
        this.amount = amount;
        this.dueDate = dueDate;
    }

    public Double getAmount() {
        return amount;
    }

    public LocalDate getDueDate() {
        return dueDate;
    }

    @Override
    public String toString() {
        return String.format("%s - %.2f", getDueDate().format(DateTimeFormatter.ofPattern("dd/MM/yyyy")) ,amount);
    }

}
