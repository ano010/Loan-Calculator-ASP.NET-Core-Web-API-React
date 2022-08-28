using LoanCalculator.Core;
using Microsoft.AspNetCore.Mvc;

namespace LoanCalculator.Controllers
{
    [Route("api/v1/calculationTypes")]
    [ApiController]
    public class CalculationTypesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CalculationTypesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetCalculationTypes()
        {
            var calculationTypes = _unitOfWork.CalculationTypes.GetAll();  

            return Ok(calculationTypes);
        }
    }
}
