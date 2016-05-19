using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class CurrencyConverter : Form
    {
        public CurrencyConverter()
        {
            InitializeComponent();
        }

        private void CurrencyConverter_Load(object sender, EventArgs e)
        {
            Convert();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Convert();
        }

        void Convert()
        {
            var amount = this.numericUpDown1.Value;
            var amountInEUR = amount / 1.95583m;
            this.labelResult.Text =
               amount + "лева =" + Math.Round(amountInEUR, 2) + "евро";
        }

        private void numericUpDown1_KeyUp(object sender, KeyEventArgs e)
        {
            Convert();
        }
    }
}
