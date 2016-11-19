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
        private readonly BirthdayParty _birthdayParty;
        public Form1()
        {
            InitializeComponent();
            _dinnerParty = new DinnerParty((int)numericUpDown1.Value, checkBox1.Checked, checkBox2.Checked);
            _birthdayParty= new BirthdayParty((int)numericUpDown2.Value, checkBox3.Checked, textBox1.Text);
            _dinnerParty.SetHealtyhyOption(false);
            _dinnerParty.CalculateCostOfDecorations(true);
            DisplayDinnerPartyCost();
            DisplayBirthdayPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal cost = _dinnerParty.CalculateCost();
            label3.Text = cost.ToString("c");
        }
        private void DisplayBirthdayPartyCost()
        {
            decimal cost = _birthdayParty.CalculateCost();
            label5.Text = cost.ToString("c");
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

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            _birthdayParty.NumberOfPeople = (int) numericUpDown2.Value;
            _birthdayParty.CakeWriting = textBox1.Text;
            textBox1.Text = _birthdayParty.CakeWriting;
            DisplayBirthdayPartyCost();
        }
     
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            _birthdayParty.CalculateCostOfDecorations(checkBox3.Checked);
            DisplayBirthdayPartyCost();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _birthdayParty.CakeWriting = textBox1.Text;
            textBox1.Text = _birthdayParty.CakeWriting;
            DisplayBirthdayPartyCost();
        }
    }
}
