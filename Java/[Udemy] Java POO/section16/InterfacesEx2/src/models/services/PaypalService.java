package models.services;

public class PaypalService implements OnlinePaymentService {

    private double paymentFee = 0.02;
    private double monthlyInterest = 0.01;

    @Override
    public Double calculateInterest(Double amount, Integer months) {
        return amount * monthlyInterest * months;
    }

    @Override
    public Double calculatePaymentFee(Double amount) {
        return amount * paymentFee;
    }

}
