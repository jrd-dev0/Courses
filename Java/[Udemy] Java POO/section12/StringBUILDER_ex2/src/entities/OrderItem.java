package entities;

public class OrderItem {
	
	private Product product;
	private Integer quantity;
	private Double price;
	
	public OrderItem(Product product, Integer quantity) {
		this.product = product;
        this.quantity = quantity;
        this.price = subTotal();
	}
	
	public Product getProduct() {
        return product;
    }
	
	public Integer getQuantity() {
        return quantity;
    }
	
	public Double getPrice() {
        return price;
    }
	
	public void setProduct(Product product) {
        this.product = product;
    }
	
	public void setQuantity(Integer quantity) {
        this.quantity = quantity;
    }
	
	public void setPrice(Double price) {
        this.price = price;
    }
	
	public Double subTotal() {
        return getProduct().getPrice() * quantity;
    }
	
	@Override
    public String toString() {
        return String.format("%s, $%.2f, Quantity: %d, Subtotal: $%.2f", getProduct().getName(), getProduct().getPrice(), getQuantity(), subTotal());
    }
}
