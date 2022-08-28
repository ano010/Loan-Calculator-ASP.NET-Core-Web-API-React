namespace LoanCalculator.Core
{
    public static class LoanInstallmentCalculatorFactory
    {
        // This method can be modified to create another type of loan installment calculation.
        // Below method returns the same instance irrespective of calculator type for the mock implementation.
        public static LoanCalculator getInstance(string calculatoryType)
        {
            if (calculatoryType.Equals("EMI"))
                return new EqualMonthlyInstallmentLoanCalculator();
            else  return new EqualMonthlyInstallmentLoanCalculator();
        }
    }
}
