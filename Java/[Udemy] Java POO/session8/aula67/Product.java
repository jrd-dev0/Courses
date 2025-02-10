package aula67;

public class Product {
	
	public String Name;
	public double Price;
	public int Quantity;
	
	public Product() {}
	
	public double TotalValueInStock() {
		return Price * Quantity;
	}
	
	public void AddProduct(int quantity) {
		Quantity += quantity;
	}
	
	public void RemoveProduct(int quantity) {
		Quantity -= quantity;
	}
	
	public String toString() {
		return String.format("%s, $ %.2f, %d units, Total: $ %.2f%n", Name, Price, Quantity, TotalValueInStock());
	}

}