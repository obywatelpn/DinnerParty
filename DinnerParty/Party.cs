using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerParty
{
    public class Party
    {
        private bool _fantasyDecorations;
        private decimal _costOfDecorations = 0;
        public const decimal CostOfFoodPerPerson = 25.0M;
        private int _numberOfPeople;

        public Party(int numberOfPersons, bool fantasyDecorations)
        {
            this.NumberOfPeople = numberOfPersons;
            this._fantasyDecorations = fantasyDecorations;
        }

        public virtual int NumberOfPeople
        {
            get { return _numberOfPeople; }
            set
            {
                _numberOfPeople = value;
                CalculateCostOfDecorations(_fantasyDecorations);
            }
        }

        public virtual void CalculateCostOfDecorations(bool fantasyDecorations)
        {
            this._fantasyDecorations = fantasyDecorations;
            _costOfDecorations = fantasyDecorations ? (this.NumberOfPeople * 15.0M) + 50.0M : (this.NumberOfPeople * 7.5M) + 30.0M;
        }

        public virtual decimal CalculateCost()
        {

            decimal totalCostDecimal = _costOfDecorations +
                                       (CostOfFoodPerPerson * this.NumberOfPeople);
            if (NumberOfPeople > 12)
            {
                totalCostDecimal = totalCostDecimal + 100M;
            }
            return totalCostDecimal;
        }
    }
}