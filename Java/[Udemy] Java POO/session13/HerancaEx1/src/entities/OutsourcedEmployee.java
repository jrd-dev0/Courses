package entities;

public class OutsourcedEmployee extends Employee {

	private Double additionalCharge;
	
	public OutsourcedEmployee(String name, Integer hours, Double valuePerHour, Double additionalCharge) {
		super(name, hours, valuePerHour);
		this.additionalCharge = additionalCharge;
	}
	
	public Double getAdditionalCharge() {
        return additionalCharge;
    }
	
	public void setAdditionalCharge(Double additionalCharge) {
        this.additionalCharge = additionalCharge;
    }
	
	@Override
	public final Double payment() {
        return super.payment() + getAdditionalCharge() * 1.1;
    }
	
	@Override
	public String toString() {
        return String.format("%s - $%.2f", super.getName(), payment());
    }
}
