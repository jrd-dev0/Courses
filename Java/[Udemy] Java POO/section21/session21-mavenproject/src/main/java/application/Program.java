package application;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;

import entities.Client;

public class Program {

	public static void main(String[] args) {
		
		Client client1 = new Client(1, "Carlos da Silva", "carlos@gmail.com");
		Client client2 = new Client(2, "Joaquim Torres", "joaquim@gmail.com");
		Client client3 = new Client(3, "Ana Maria", "ana@gmail.com");
		
		EntityManagerFactory emf = Persistence.createEntityManagerFactory("exemplo-jpa");
		EntityManager em = emf.createEntityManager();
		em.getTransaction().begin();
		em.persist(client1);
		em.persist(client2);
		em.persist(client3);
		em.getTransaction().commit();
		System.out.println("done!");

	}

}
