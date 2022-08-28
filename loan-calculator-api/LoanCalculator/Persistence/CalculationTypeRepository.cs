using LoanCalculator.Core.Models;
using LoanCalculator.Core.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace LoanCalculator.Persistence
{
    // This class contains a hard coded values for calculations types.
    // It can be used to extent the application by implementing database connection
    public class CalculationTypeRepository : ICalculationTypesRepository
    {
        private static IList<CalculationType> calculationTypes = new List<CalculationType>
        {
            new CalculationType {Id = 1, Name = "EMI" }
        };

        public  CalculationType FindById(int id)
        {
            return calculationTypes.FirstOrDefault(ct => ct.Id == id);
        }

        public   IEnumerable<CalculationType> GetAll()
        {
            return calculationTypes;
        }
    }
}

