using LoanCalculator.Core.Models;
using System.Collections;
using System.Collections.Generic;

namespace LoanCalculator.Core.Repositories
{
    public interface ICalculationTypesRepository
    {
        public IEnumerable<CalculationType> GetAll();
        public CalculationType FindById(int id);
    }
}
