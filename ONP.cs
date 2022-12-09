using System;
using System.Collections.Generic;

namespace ONP
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<double> operandStack = new Stack<double>();

            string[] onpExpression = new string[] { "2", "3", "+", "5", "*" };

            foreach (string element in onpExpression)
            {
                if (double.TryParse(element, out double operand))
                {
                    operandStack.Push(operand);
                }
                else
                {
                    double operand2 = operandStack.Pop();
                    double operand1 = operandStack.Pop();

                    switch (element)
                    {
                        case "+":
                            operandStack.Push(operand1 + operand2);
                            break;
                        case "-":
                            operandStack.Push(operand1 - operand2);
                            break;
                        case "*":
                            operandStack.Push(operand1 * operand2);
                            break;
                        case "/":
                            operandStack.Push(operand1 / operand2);
                            break;
                    }
                }
            }

            Console.WriteLine(operandStack.Pop());
        }
    }
}