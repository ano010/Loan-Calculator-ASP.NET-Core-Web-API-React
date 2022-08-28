namespace LoanCalculator.Core
{
    public static class LoanInstallmentCalculatorFactory
    {
        // This method can be modified create another type of loan installment calculation
        // For the prototype below method return the same instance irrespective of calculator type
        public static LoanCalculator getInstance(string calculatoryType)
        {
            if (calculatoryType.Equals("EMI"))
                return new EqualMonthlyInstallmentLoanCalculator();
            else  return new EqualMonthlyInstallmentLoanCalculator();
        }
    }
}
