package models.entities;

import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;

public class Contract {

    private Integer number;
    private LocalDate date;
    private Double value;

    private List<Installment> installments = new ArrayList<>();

    public Contract(Integer number, LocalDate date, Double value) {
        this.number = number;
        this.date = date;
        this.value = value;
    }

    public Integer getNumber() {
        return number;
    }

    public LocalDate getDate() {
        return date;
    }

    public Double getValue() {
        return value;
    }

    public void addInstallment(Installment installment) {
        installments.add(installment);
    }

    public void removeInstallment(Installment installment) {
        installments.remove(installment);
    }

    public List<Installment> getInstallments() {
        return installments;
    }

}