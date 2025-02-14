package entities;

public class ImportedProduct extends Product{
	
	private Double customFee;

	public ImportedProduct(String name, Double price, Double customFee) {
		super(name, price);
		this.customFee = customFee;
	}

	public Double getCustomFee() {
		return customFee;
	}

	public void setCustomFee(Double customFee) {
		this.customFee = customFee;
	}
	
	public Double getTotalPrice() {
        return super.getPrice() + customFee;
    }
	
	@Override
    public String priceTag() {
        return String.format("%s $ %.2f (customs fee: $ %.2f)", super.getName(), getTotalPrice(), getCustomFee());
    }
}