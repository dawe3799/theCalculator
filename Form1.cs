/*
 * Program ID: Basic Calculator
 * 
 * Purpose: Demostrating the ability to use WinForms
 * 
 * Revision history:
 *      Created by Demi Awe Nov 2021
 */
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
        bool ismathPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {   
            if((txtBoxAnswer.Text=="0") || (ismathPerformed))
            {
                txtBoxAnswer.Clear();
            }
            ismathPerformed = false;
            Button button = (Button)sender;
            if(button.Text==".")
            {
                if(!txtBoxAnswer.Text.Contains("."))
                {
                    txtBoxAnswer.Text = txtBoxAnswer.Text + button.Text;
                }
            }
            else
            {
                txtBoxAnswer.Text = txtBoxAnswer.Text + button.Text;
            }
           
        }

        private void MathOperation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (mathAnswer != 0)
            {
                btnEquals.PerformClick();
                mathOperation = button.Text;
                lblDisplay.Text = mathAnswer + " " + mathOperation;
                ismathPerformed = true;
            }
            else
            {
                mathOperation = button.Text;
                mathAnswer = Double.Parse(txtBoxAnswer.Text);
                lblDisplay.Text = mathAnswer + " " + mathOperation;
                ismathPerformed = true;
            }
           
        }

        private void btnClearnEntry_Click(object sender, EventArgs e)
        {
            txtBoxAnswer.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxAnswer.Text = "0";
            mathAnswer = 0;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            switch(mathOperation)
            {
                case "+":
                    txtBoxAnswer.Text = (mathAnswer + Double.Parse(txtBoxAnswer.Text)).ToString();
                    break;

                case "-":
                    txtBoxAnswer.Text = (mathAnswer - Double.Parse(txtBoxAnswer.Text)).ToString();
                    break;

                case "*":
                    txtBoxAnswer.Text = (mathAnswer * Double.Parse(txtBoxAnswer.Text)).ToString();
                    break;

                case "/":
                    txtBoxAnswer.Text = (mathAnswer / Double.Parse(txtBoxAnswer.Text)).ToString();
                    break;

                default:
                    break;

            }
            mathAnswer = Double.Parse(txtBoxAnswer.Text);
            lblDisplay.Text = "";
        }
    }
}
