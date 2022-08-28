using LoanCalculator.Core;
using System;
using Xunit;

namespace LoanCalculator.UnitTest
{
    public class EqualMonthlyInstallmentLoanCalculatorTest
    {
        [Fact]
        public void CalculateLoanInstallment_Returns_Correct_Monthly_Installement_Loan_Amount()
        {
            var equalMonthlyInstallmentLoanCalculator = new EqualMonthlyInstallmentLoanCalculator();
            equalMonthlyInstallmentLoanCalculator.PrincipalLoanAmount = 3500;
            equalMonthlyInstallmentLoanCalculator.InterestRate = 0.0067;
            equalMonthlyInstallmentLoanCalculator.NumberOfPayments = 36;

            var amount = equalMonthlyInstallmentLoanCalculator.CalculateLoanInstallment();
            Assert.Equal(109.74187535138536, amount);


        }
    }
}
