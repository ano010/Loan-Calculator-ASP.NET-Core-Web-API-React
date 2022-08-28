using LoanCalculator.Core.Repositories;

namespace LoanCalculator.Core
{
    public interface IUnitOfWork
    {
         public ICalculationTypesRepository CalculationTypes { get; set; }
    }
}
