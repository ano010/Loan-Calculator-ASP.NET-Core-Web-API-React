using LoanCalculator.Core.Models;
using LoanCalculator.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace LoanCalculator.Persistence
{
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

