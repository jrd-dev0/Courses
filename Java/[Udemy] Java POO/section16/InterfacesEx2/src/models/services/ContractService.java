package models.services;

import models.entities.Contract;
import models.entities.Installment;

public class ContractService {

    private OnlinePaymentService onlinePaymentService;

    public ContractService(OnlinePaymentService onlinePaymentService) {
        this.onlinePaymentService = onlinePaymentService;
    }

    public void processContract(Contract contract, Integer months) {
        double basicQuota = contract.getValue() / months;
        for (int i = 1; i <= months; i++) {
            double updatedQuota = basicQuota + onlinePaymentService.calculateInterest(basicQuota, i);
            double fullQuota = updatedQuota + onlinePaymentService.calculatePaymentFee(updatedQuota);
            contract.addInstallment(new Installment(fullQuota, contract.getDate().plusMonths(i)));
        }
    }
}