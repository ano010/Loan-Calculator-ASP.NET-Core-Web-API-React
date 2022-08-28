using LoanCalculator.Core;
using LoanCalculator.Core.Repositories;

namespace LoanCalculator.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICalculationTypesRepository CalculationTypes { get; set; }

        public UnitOfWork()
        {
            CalculationTypes = new CalculationTypeRepository();
        }
    }
}
