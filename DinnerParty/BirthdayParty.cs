using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinnerParty
{
    public class BirthdayParty:Party
    {
        public int CakeSize;
        private string _cakeWriting = "";

        public BirthdayParty(int numberOfPersons, bool fantasyDecorations, string cakeWriting)
            :base(numberOfPersons, fantasyDecorations)
        {
            CalculateCakeSize();
            this.CakeWriting = cakeWriting;
            CalculateCostOfDecorations(fantasyDecorations);

        }

        public override int NumberOfPeople
        {
            get { return base.NumberOfPeople; }
            set
            {
                base.NumberOfPeople = value;
                CalculateCakeSize();
                this.CakeWriting = _cakeWriting;
            }
        }

        public string CakeWriting
        {
            get { return this._cakeWriting; }
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
                    if (maxLength > this._cakeWriting.Length)
                    {
                        maxLength = this._cakeWriting.Length;
                    }
                    this._cakeWriting = _cakeWriting.Substring(0, maxLength);
                }
                else this._cakeWriting = value;
            }
        }

        private void CalculateCakeSize()
        {
            CakeSize = NumberOfPeople <= 4 ? 20 : 40;
        }

        public override decimal CalculateCost()
        {
            decimal cakeCost;
            if (CakeSize==8)
            {
                cakeCost = 40M + CakeWriting.Length*0.25M;
            }
            else
            {
                cakeCost = 75M + CakeWriting.Length*0.25M;
            }
            return base.CalculateCost() + cakeCost;
        }
    }
}
