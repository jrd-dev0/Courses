package aula70_Ex2;

public class Employee {
	
	public String Name;
	public double GrossSalary;
	public double Tax;
	
	public double NetSalary() {
		return GrossSalary - Tax;
	}
	
	public void IncreaseSalary(double percentage) {
		GrossSalary += (GrossSalary * (percentage / 100));
	}
	
	public String toString() {
		return String.format("%s, $ %.2f%n", Name, NetSalary());
	}
}