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
        public int CakeSize { get; set; }

        public string CakeWriting
        {
            get { return this.cakeWriting; }
            private set
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
            get { return NumberOfPeople; }
            set { CalculateCakeSize(); }
        }

        private void CalculateCakeSize()
        {
            switch (numberOfPersons)
            {
                case 20:
                    CakeSize = 20;
                    break;
                case 40:
                    CakeSize = 40;
                    break;
            }
        }
    }
}
