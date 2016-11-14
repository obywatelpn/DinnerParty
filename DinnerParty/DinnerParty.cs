using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinnerParty
{
    class DinnerParty
    {
        private int _numberOfPeople;
        public int NumberOfPeople {
            get { return this._numberOfPeople; }
            set
            {
                this._numberOfPeople = value;
                CalculateCostOfDecorations(this._fantasyDecorations);
            } 
        }
        private decimal _costOfBeveragesPerPerson;
        public const decimal CostOfFoodPerPerson = 25.0M;
        private decimal _costOfDecorations = 0;
        private bool _healthyOption;
        private bool _fantasyDecorations;

        public DinnerParty(int numberOfPeople, bool fantasyDecorations, bool healthyOption)
        {
            this.NumberOfPeople = numberOfPeople;
            this._fantasyDecorations = fantasyDecorations;
            this._healthyOption = healthyOption;

            CalculateCostOfDecorations(_fantasyDecorations);
            SetHealtyhyOption(_healthyOption);
        }

        public void SetPartyOptions(int numberOfPeoplem, bool fantasy, bool healthy)
        {
            this.NumberOfPeople = numberOfPeoplem;
            CalculateCostOfDecorations(fantasy);
            SetHealtyhyOption(healthy);
        }
        
        public void CalculateCostOfDecorations(bool fantasyDecorations)
        {
            this._fantasyDecorations = fantasyDecorations;
            _costOfDecorations = fantasyDecorations ? (this.NumberOfPeople*15.0M) + 50.0M : (this.NumberOfPeople*7.5M) + 30.0M;
        }

        public void SetHealtyhyOption(bool healthyOption)
        {
            this._healthyOption = healthyOption;
            _costOfBeveragesPerPerson = healthyOption ? 5.0M : 20.0M;
        }
        public decimal CalculateCost()
        {
            
            decimal totalCostDecimal = _costOfDecorations +
                                       ((_costOfBeveragesPerPerson + CostOfFoodPerPerson)*this.NumberOfPeople);
            if (NumberOfPeople > 12)
            {
                totalCostDecimal = totalCostDecimal + 100M;
            }
            if (this._healthyOption)
            {
                return totalCostDecimal * 0.95M;
            }
            else return totalCostDecimal;
        }
    }
}
