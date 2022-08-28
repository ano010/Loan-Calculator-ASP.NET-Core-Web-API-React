using System.ComponentModel.DataAnnotations;

namespace LoanCalculator.Controllers.Resources
{
    public class LoanDetailsResource
    {
        [Required]
        [Range(0, double.MaxValue)]
        public double PrincipalLoanAmount { get; set; }
        [Required]
        [Range(0, double.MaxValue)]
        public double InterestRate { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int NumberOfPayments { get; set; }
        [Required]
        [Range(1, 100)]
        public int CalculationType { get; set; }
    }
}
