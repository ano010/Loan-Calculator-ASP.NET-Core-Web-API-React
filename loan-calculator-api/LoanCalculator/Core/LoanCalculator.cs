namespace LoanCalculator.Core
{
    public abstract class LoanCalculator : ILoanCalculator
    {
        public double PrincipalLoanAmount { get; set; }
        public double InterestRate { get; set; }
        public double NumberOfPayments { get; set; }
        public abstract double CalculateLoanInstallment();
    }
}
