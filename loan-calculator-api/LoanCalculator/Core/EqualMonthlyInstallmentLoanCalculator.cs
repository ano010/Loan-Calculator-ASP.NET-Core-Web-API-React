using System;

namespace LoanCalculator.Core
{
    public class EqualMonthlyInstallmentLoanCalculator : LoanCalculator
    {
        public override double CalculateLoanInstallment()
        {
            var emi = this.PrincipalLoanAmount *
                this.InterestRate *
                Math.Pow((1 + this.InterestRate), this.NumberOfPayments) /
                (Math.Pow((1 + this.InterestRate), this.NumberOfPayments) - 1 );

            return emi;
        }
    }
}
