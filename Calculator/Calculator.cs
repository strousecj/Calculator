using System;

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
                    if(operand2 == 0)
                    {
                        return 0;
                    }

                    return operand1 / operand2;

                default:
                    throw new InvalidOperationException("Error: That operation does not exist");
            }
        }
    }
}
