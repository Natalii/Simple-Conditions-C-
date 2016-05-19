using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchTheButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {

        }

        private void CatchMe_Mouse_Enter_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            var maxWidth = this.Width - CatchMe_Mouse_Enter.ClientSize.Width;
            var maxHeight = this.Height - CatchMe_Mouse_Enter.ClientSize.Height;
            this.CatchMe_Mouse_Enter.Location = new Point(
                rand.Next(maxWidth), rand.Next(maxHeight)
                );
        }
    }
}

