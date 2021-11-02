using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theCalculator
{
    public partial class Form1 : Form
    {
        Double mathAnswer = 0;
        String mathOperation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {   
            if(txtBoxAnswer.Text=="0")
            {
                txtBoxAnswer.Clear();
            }
            Button button = (Button)sender;
            txtBoxAnswer.Text = txtBoxAnswer.Text + button.Text;
        }

        private void MathOperation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
        }
    }
}
