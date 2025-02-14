package aula70_Ex3;

public class Student {

	public String Name;
	public double Score1;
	public double Score2;
	public double Score3;
	
	public double FinalGrade() {
		return Score1 + Score2 + Score3;
	}
	
	public double MissingPoints() {
		if (FinalGrade() > 60.0) {
			return 0.0;
		}
		
		return 60.0 - FinalGrade();
	}
}	