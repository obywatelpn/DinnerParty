using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinnerParty
{
    public class DinnerParty:Party
    {
        private decimal _costOfBeveragesPerPerson;

        public DinnerParty(int numberOfPeople, bool fantasyDecorations, bool healthyOption) 
            : base(numberOfPeople, fantasyDecorations)
        {
            CalculateCostOfDecorations(fantasyDecorations);
            SetHealtyhyOption(healthyOption);
        }

        public void SetPartyOptions(int numberOfPeoplem, bool fantasy, bool healthy)
        {
            this.NumberOfPeople = numberOfPeoplem;
            CalculateCostOfDecorations(fantasy);
            SetHealtyhyOption(healthy);
        }

        public void SetHealtyhyOption(bool healthyOption)
        {
            _costOfBeveragesPerPerson = healthyOption ? 5.0M : 20.0M;
        }

        public decimal CalculateCost(bool healthyOption)
        {

            decimal totalCostDecimal = base.CalculateCost() + (_costOfBeveragesPerPerson*NumberOfPeople);
            if (healthyOption)
            {
                return totalCostDecimal * 0.95M;
            }
            else return totalCostDecimal;
        }
    }
}
