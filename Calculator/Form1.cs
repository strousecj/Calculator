using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        // Called when a number button (0-9) or decimal button is pressed 
        private void NumberButton_Click(string number)
        {
            if(Calculator.StartNewCalculation == true) // if the user has just pressed the equals button, remove previous calculation information
            {
                Calculator.ClearAll();
                Calculator.StartNewCalculation = false;
            }

            txtDisplay.Text = "";
            Calculator.ClearOperand2();
            Calculator.ResetResult();

            if (Calculator.Input == "0") // prevents numbers from displaying with leading zeros
            {
                Calculator.Input = number;
            }
            else
            {
                Calculator.Input += number;
            }
            txtDisplay.Text += Calculator.Input; // update display
        }

        // Called whenever one of the operation buttons is pressed (+,-,*,/)
        private void OperationButton_Click(char op)
        {
            if (Calculator.IsOperand1Blank() && Calculator.Result == 0) // operand needs to have a value before continuing 
            {
                Calculator.Operand1 = Calculator.Input;
            }
            else
            {
                if (!Calculator.IsInputBlank()) // if input is blank, then operand2 will be blank in the upcoming calculation
                {
                    EvaluateExpression();
                }
            }
            Calculator.Operation = op;
            Calculator.ClearOperand2();
            Calculator.ClearInput();
            Calculator.StartNewCalculation = false;
        }

        // called when the equals button is pressed or to evaluate 
        private void EvaluateExpression()
        {
            txtDisplay.Text = "";
            if (!Calculator.IsInputBlank())
            {
                Calculator.Operand2 = Calculator.Input;
            }

            if (Calculator.Operation == '/' && Calculator.Operand2 == "0") // prevent divide by zero problems
            {
                Calculator.ClearAll();
                txtDisplay.Text = "Cannot divide by zero";
            }
            else
            {
                Calculator.Result = Calculator.Calculate(Calculator.Operation, Calculator.Operand1, Calculator.Operand2);
                txtDisplay.Text += Calculator.Result.ToString();   
                Calculator.Operand1 = Calculator.Result.ToString();   // so the result can be used for another calculation
                Calculator.ClearInput();
            }
            Calculator.StartNewCalculation = true;
        }

        // Windows Forms Button Region
        private void btnOne_Click(object sender, EventArgs e)
        {
            NumberButton_Click("1");
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            NumberButton_Click("2");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            NumberButton_Click("3");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            NumberButton_Click("4");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            NumberButton_Click("5");
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            NumberButton_Click("6");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            NumberButton_Click("7");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            NumberButton_Click("8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            NumberButton_Click("9");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            NumberButton_Click("0");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OperationButton_Click('+');
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            OperationButton_Click('-');
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            OperationButton_Click('*');
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            OperationButton_Click('/');
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (!Calculator.IsOperand1Blank()) // will cause error if there are not 2 values for the calculation
            {
                EvaluateExpression();
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!Calculator.Input.Contains(".")) { // prevent multiple decimal points in a number
                NumberButton_Click(".");
            }
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            Calculator.ClearEntry();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            Calculator.ClearAll();
        }
        // End Form Button Region
    }
}
