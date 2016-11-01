using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerParty
{
    class DinnerParty
    {
        public int NumberOfPeople;
        public decimal CostOfBeveragesPerPerson;
        public const decimal CostOfFoodPerPerson = 25.0M;
        private decimal CostOfDecorations = 0;
        private bool HealthyOption;
        


        public void CalculateCostOfDecorations(bool fantasyDecorations)
        {
        }
        public  void SetHealtyhyOption(bool healthyOption) { }
        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCostDecimal = CostOfDecorations +
                                       ((CostOfBeveragesPerPerson + CostOfFoodPerPerson)*NumberOfPeople);
            if (healthyOption)
            {
                return totalCostDecimal * 0.95M;
            }
            else return totalCostDecimal;
        }
    }
}
