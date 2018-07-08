using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmCalculator : Form
    {
        private string input = "";      // user input, modified as user presses buttons to enter numbers
        private string operand1 = "";   
        private string operand2 = "";   
        private char operation;
        private double result = 0.0;    
        private bool startNewCalculation = false;

        public frmCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        // Called when a number button (0-9) or decimal button is pressed 
        private void NumberButton_Click(string number)
        {
            if(startNewCalculation == true) // if the user has just pressed the equals button, remove previous calculation information
            {
                ClearAll();
                startNewCalculation = false;
            }

            txtDisplay.Text = "";
            operand2 = "";
            result = 0.0;

            if (input == "0") // prevents numbers from displaying with leading zeros
            {
                input = number;
            }
            else
            {
                input += number;
            }
            txtDisplay.Text += input; // update display
        }

        // Called whenever one of the operation buttons is pressed (+,-,*,/)
        private void OperationButton_Click(char op)
        {
            if (operand1 == "" && result == 0) // operand needs to have a value before continuing 
            {
                operand1 = input;
            }
            else
            {
                if (input != "") // if input is blank, then operand2 will be blank in the upcoming calculation
                {
                    EvaluateExpression();
                }
            }
            operation = op;
            operand2 = "";
            input = "";
            startNewCalculation = false;
        }

        // called when the equals button is pressed or to evaluate 
        private void EvaluateExpression()
        {
            txtDisplay.Text = "";
            if (input != "")
            {
                operand2 = input;
            }
            if (operation == '/' && operand2 == "0") // prevent divide by zero problems
            {
                ClearAll();
                txtDisplay.Text = "Cannot divide by zero";
            }
            else
            {
                result = Calculator.Calculate(operation, operand1, operand2);
                txtDisplay.Text += result.ToString();   
                operand1 = result.ToString();   // so the result can be used for another calculation
                input = "";
            }
            startNewCalculation = true;
        }

        // called when the CE button is pressed, clear current entry only
        private void ClearEntry()
        {
            txtDisplay.Text = "";
            input = "";
            result = 0.0;
        }

        // called when clear button is pressed, clears all previous calculations and input from the calculator
        private void ClearAll()
        {
            ClearEntry();
            operand1 = "";
            operand2 = "";
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
            if (operand1 != "") // will cause error if there are not 2 values for the calculation
            {
                EvaluateExpression();
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!input.Contains(".")) { // prevent multiple decimal points in a number
                NumberButton_Click(".");
            }
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            ClearEntry();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        // End Form Button Region
    }
}
