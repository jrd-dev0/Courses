package entities;

import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.util.ArrayList;
import java.util.List;
import entities.enums.OrderStatus;

public class Order {
	
	private Client client;
	private LocalDateTime date;
	private OrderStatus status;
	
	private List<OrderItem> orders = new ArrayList<>();

	public Order(Client client, LocalDateTime date, OrderStatus status) {
		this.client = client;
		this.date = date;
		this.status = status;
	}

	public Client getClient() {
		return client;
	}

	public void setClient(Client client) {
		this.client = client;
	}

	public LocalDateTime getDate() {
		return date;
	}

	public void setDate(LocalDateTime date) {
		this.date = date;
	}

	public OrderStatus getStatus() {
		return status;
	}

	public void setStatus(OrderStatus status) {
		this.status = status;
	}

	public List<OrderItem> getOrders() {
		return orders;
	}
	
	public void addItem(OrderItem orderItem) {
        orders.add(orderItem);
    }
	
	public void removeItem(OrderItem orderItem) {
        orders.remove(orderItem);
    }
	
	public double total() {
		double total = 0.0;
        for(OrderItem item : orders) {
            total += item.subTotal();
        }
        return total;
	}
	
	@Override
    public String toString() {
		
		DateTimeFormatter fmt = DateTimeFormatter.ofPattern("dd/MM/yyyy HH:mm:ss");
		StringBuilder sb = new StringBuilder();
		
        sb.append(String.format("Order moment: %s%n", getDate().format(fmt)));
        sb.append(String.format("Order status: %s%n", getStatus()));
        sb.append(String.format("-----------------%n"));
        sb.append(String.format("Client: %s%n", getClient()));
        sb.append(String.format("-----------------%n"));
        sb.append(String.format("Order items:%n"));
        for(OrderItem item : orders) {
        	sb.append(String.format("%s%n", item));
        }
        sb.append(String.format("-----------------%n"));
        sb.append(String.format("Total price: $%.2f%n", total()));
        
        return sb.toString();
	}
}
