using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinnerParty
{
    class BirthdayParty
    {
        private string cakeWriting = "";
        private decimal _numberOfPeople;
        private decimal _fantasyDecorationsCost;
        private decimal _cakeCost;

        public BirthdayParty(decimal numberOfPersons, bool fantasyDecorations, string cakeWriting)
        {
            this.NumberOfPeople = numberOfPersons;
            CalculateCostOfDecorations(fantasyDecorations);
            this.CakeWriting = cakeWriting;

        }
        public int CakeSize { get; set; }
        public string CakeWriting
        {
            get { return this.cakeWriting; }
            set
            {
                int maxLength;
                if (CakeSize == 20)
                {
                    maxLength = 16;
                }
                else maxLength = 40;

                if (value.Length > maxLength)
                {
                    MessageBox.Show("Za dużo liter dla " + CakeSize + "-centymetrowego tortu");
                    if (maxLength > this.cakeWriting.Length)
                    {
                        maxLength = this.cakeWriting.Length;
                    }
                    this.cakeWriting = cakeWriting.Substring(0, maxLength);
                }
                else this.cakeWriting = value;
            }
        }

        public decimal NumberOfPeople
        {
            get { return _numberOfPeople; }
            set
            {
                _numberOfPeople = value;
                CalculateCakeSize();
            }
        }

        private void CalculateCakeSize()
        {
            if (_numberOfPeople <= 4)
            {
                CakeSize = 20;
                _cakeCost = 40M;
            }
            else if (_numberOfPeople > 4)
            {
                CakeSize = 40;
                _cakeCost = 75M;
            }
        }

        public void CalculateCostOfDecorations(bool fantasyDecorations)
        {
            if (fantasyDecorations)
            {
                this._fantasyDecorationsCost= NumberOfPeople*15M + 50M;
            }
            else this._fantasyDecorationsCost = NumberOfPeople *7.5M + 30M;
        }
        public decimal CalculateCost()
        {
            return (NumberOfPeople*25) + _fantasyDecorationsCost + _cakeCost + (CakeWriting.Length*0.25M);
        }
    }
}
