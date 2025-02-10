package models.services;

public interface OnlinePaymentService {

    public Double calculateInterest(Double amount, Integer months);
    public Double calculatePaymentFee(Double amount);
}
