using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator;

namespace Calculator
{
    

    public partial class frmCalculator : Form
    {
        private string input = "";
        private string operand1 = "";
        private string operand2 = "";
        private char operation;
        private double result = 0.0;

        public frmCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            input += "1";
            txtDisplay.Text += input;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            input += "2";
            txtDisplay.Text += input;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            input += "3";
            txtDisplay.Text += input;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            input += "4";
            txtDisplay.Text += input;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            input += "5";
            txtDisplay.Text += input;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            input += "6";
            txtDisplay.Text += input;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            input += "7";
            txtDisplay.Text += input;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            input += "8";
            txtDisplay.Text += input;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            input += "9";
            txtDisplay.Text += input;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            input += "0";
            txtDisplay.Text += input;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = "";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = "";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = "";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = "";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            operand2 = input;
            result = Calculator.Calculate(operation, operand1, operand2);
            txtDisplay.Text += result.ToString();
            input = result.ToString();
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            input += ".";
            txtDisplay.Text += input;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            input = "";
            operand1 = "";
            operand2 = "";
            txtDisplay.Text = "";
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            input = "";
        }
    }
}
