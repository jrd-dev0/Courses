package entities;

import java.time.LocalDate;
import java.time.format.DateTimeFormatter;

public class Client {
	
	private String name;
	private String email;
	private LocalDate birthdate;
	
	public Client(String name, String email, LocalDate birthdate) {
		this.name = name;
		this.email = email;
		this.birthdate = birthdate;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getEmail() {
		return email;
	}

	public void setEmail(String email) {
		this.email = email;
	}

	public LocalDate getBirthdate() {
		return birthdate;
	}

	public void setBirthdate(LocalDate birthdate) {
		this.birthdate = birthdate;
	}

	@Override
	public String toString() {
		return String.format("%s %s - %s", getName(), DateTimeFormatter.ofPattern("dd/MM/yyyy").format(birthdate), getEmail());
	}
}
