using LoanCalculator.Controllers.Resources;
using LoanCalculator.Core;
using LoanCalculator.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace LoanCalculator.Controllers
{
    [Route("api/v1/loanInstallmentCalculator")]
    [ApiController]
    public class LoanInstallmentCalculatorController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public LoanInstallmentCalculatorController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;   
        }

        [HttpPost]
        public IActionResult CalculateLoanInstallment(LoanDetailsResource loanDetails)
        {
            var calculationType = this._unitOfWork.CalculationTypes.FindById(1);
            if (calculationType == null)
            {
                ModelState.AddModelError("calculalationType", "calculationType is not valid");
                return BadRequest(ModelState);

            }

            var loanInstallmentCalculator = LoanInstallmentCalculatorFactory.getInstance("EMI");

            loanInstallmentCalculator.PrincipalLoanAmount = loanDetails.PrincipalLoanAmount;
            loanInstallmentCalculator.InterestRate = loanDetails.InterestRate / 100;
            loanInstallmentCalculator.NumberOfPayments = loanDetails.NumberOfPayments;

            var amount = loanInstallmentCalculator.CalculateLoanInstallment();

            return Ok(amount);
        }
    }
}
