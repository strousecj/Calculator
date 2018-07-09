using System;

namespace Calculator
{
    public static class Calculator
    { 
        public static string Operand1 { get; set; }
        public static string Operand2 { get; set; }
        public static string Input { get; set; }
        public static char Operation { get; set; }
        public static double Result { get; set; }
        public static bool StartNewCalculation { get; set; }

        public static void ClearInput()
        {
            Input = "";
        }

        public static void ClearOperand1()
        {
            Operand1 = "";
        }

        public static void ClearOperand2()
        {
            Operand2 = "";
        }

        public static void ClearEntry()
        {
            ClearInput();
            ResetResult();
        }

        public static void ClearAll()
        {
            ClearEntry();
            ClearOperand1();
            ClearOperand2();
        }

        public static void ResetResult()
        {
            Result = 0.0;
        }

        public static bool IsInputBlank()
        {
            if(Input == "" || Input == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsOperand1Blank()
        {
            if(Operand1 == "" || Operand1 == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsOperand2Blank()
        {
            if(Operand2 == "" || Operand2 == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

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
