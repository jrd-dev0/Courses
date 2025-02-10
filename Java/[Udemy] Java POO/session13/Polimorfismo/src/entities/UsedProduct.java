package entities;

import java.time.LocalDate;
import java.time.format.DateTimeFormatter;

public class UsedProduct extends Product {

	private LocalDate date;

	public UsedProduct(String name, Double price, LocalDate date) {
		super(name, price);
		this.date = date;
	}

	public LocalDate getDate() {
		return date;
	}

	public void setDate(LocalDate date) {
		this.date = date;
	}
	
	@Override
    public String priceTag() {
        return String.format("%s (used) $ %.2f (Manufacture date: %s)", super.getName(), super.getPrice(), DateTimeFormatter.ofPattern("dd/MM/yyyy").format(getDate()));
    }
}
