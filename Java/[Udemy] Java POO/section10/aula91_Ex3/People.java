package aula91_Ex3;

public class People {
	
	private String name;
	private int age;
	private double height;
	
	public People(String name, int age, double height) {		
		this.name = name;
		this.age = age;
		this.height = height;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public int getAge() {
		return age;
	}

	public double getHeight() {
		return height;
	}
	
	public static double averageHeight(People[] people) {
		
		double avgHeight = 0.0;
		
		for(People p : people) {
			
			avgHeight += p.height;
		}
		
		avgHeight /= people.length;
		
		return avgHeight ;
	}
	
	public static double percentageOfPeopleUnder16(People[] people) {
		
		double peopleUnder16 = 0.0;
		
		for(People p : people) {
			
			if(p.age < 16) {
				
				peopleUnder16++;
			}
		}
		
		return (peopleUnder16 / people.length) * 100.0;
	}
	
	public static void nameOfPeopleUnder16(People[] people) {
		
		for(People p : people) {

			if(p.age < 16) {

				System.out.println(p.name);
			}
		}

	}
}