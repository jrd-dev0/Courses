package aula73;

public class CurrencyConverter {
	
	public static double IOF_Dolar = 0.06;
	
	public static double Real(double dolarPrice, double amount) {
		double dolar = amount * dolarPrice;
		return dolar += (dolar * IOF_Dolar);
	}

}
