package aula82;

public class Account {
	
	private int accountNumber;
	private String name;
	private double balance;
	
	public Account(int accountNumber, String name, double initialBalance) {
		this.accountNumber = accountNumber;
		this.name = name;
		deposit(initialBalance);
	}
	
	public Account(int accountNumber, String name) {
		this.accountNumber = accountNumber;
		this.name = name;
	}
	
	
	public void setName(String name) {
		this.name = name;
	}
	
	public int getAccountNumber() {
		return accountNumber;
	}
	
	public String getName() {
		return name;
	}
	
	public double getBalance() {
		return balance;
	}
	
	public void deposit(double amount) {
		balance += amount;
	}
	
	public void withdraw(double amount) {
		balance -= (amount + 5.00);
	}
	
	public String toString() {
		return String.format("Account %d, Holder: %s, Balance: $ %.2f%n", getAccountNumber(), getName(), getBalance());
	}

}
