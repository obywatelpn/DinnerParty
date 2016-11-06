using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinnerParty
{
    public partial class Form1 : Form
    {
        private readonly DinnerParty _dinnerParty;
        public Form1()
        {
            InitializeComponent();
            _dinnerParty = new DinnerParty((int)numericUpDown1.Value, checkBox1.Checked, checkBox2.Checked);
            _dinnerParty.SetHealtyhyOption(false);
            _dinnerParty.CalculateCostOfDecorations(true);
            DisplayDinnerPartyCost();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DisplayDinnerPartyCost()
        {
            decimal cost = _dinnerParty.CalculateCost();
            label3.Text = cost.ToString("c");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            _dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            _dinnerParty.SetPartyOptions((int) numericUpDown1.Value, checkBox1.Checked, checkBox2.Checked);
            DisplayDinnerPartyCost();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            _dinnerParty.CalculateCostOfDecorations(checkBox1.Checked);
            DisplayDinnerPartyCost();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            _dinnerParty.SetHealtyhyOption(checkBox2.Checked);
            DisplayDinnerPartyCost();
        }
    }
}
