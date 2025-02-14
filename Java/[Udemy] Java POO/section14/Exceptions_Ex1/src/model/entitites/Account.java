package model.entitites;

import model.exceptions.DomainException;

public class Account {
    private Integer number;
    private String holder;
    private Double balance;
    private Double withdrawBalance;

    public Account(Integer number, String holder, Double balance, Double withdrawBalance) {
        this.number = number;
        this.holder = holder;
        this.balance = balance;
        this.withdrawBalance = withdrawBalance;
    }

    public Integer getNumber() {
        return number;
    }

    public String getHolder() {
        return holder;
    }

    public void setHolder(String holder) {
        this.holder = holder;
    }

    public Double getBalance() {
        return balance;
    }

    public Double getWithdrawBalance() {
        return withdrawBalance;
    }

    public void setWithdrawBalance(Double withdrawBalance) {
        this.withdrawBalance = withdrawBalance;
    }

    public void deposit(Double amount) {
        balance += amount;
    }

    public void withdraw(Double amount) {
        if(amount > withdrawBalance){
            throw new DomainException("The amount exceeds withdraw limit");
        }
        balance -= amount;
    }
}
