using LoanCalculator.Core;
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

        [Fact]
        public void CalculateLoanInstallment_Returns_Zero_Monthly_Installement_Loan_Amount()
        {
            var equalMonthlyInstallmentLoanCalculator = new EqualMonthlyInstallmentLoanCalculator();
            equalMonthlyInstallmentLoanCalculator.PrincipalLoanAmount = 0;
            equalMonthlyInstallmentLoanCalculator.InterestRate = 6;
            equalMonthlyInstallmentLoanCalculator.NumberOfPayments = 6;

            var amount = equalMonthlyInstallmentLoanCalculator.CalculateLoanInstallment();
            Assert.Equal(0, amount);


        }
    }
}
