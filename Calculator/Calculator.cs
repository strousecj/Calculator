using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {

        public static double Calculate(char operation, string operand1String, string operand2String)
        {
            Double.TryParse(operand1String, out double operand1);
            Double.TryParse(operand2String, out double operand2);

            switch (operation)
            {
                case '+':
                    return operand1 + operand2;

                case '-':
                    return operand1 - operand2;

                case '*':
                    return operand1 * operand2;

                case '/':
                    return operand1 / operand2;

                default:
                    throw new InvalidOperationException("Error: That operation doesn not exist");
            }
        }
    }
}
