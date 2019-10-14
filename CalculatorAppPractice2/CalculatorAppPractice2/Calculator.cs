using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAppPractice2
{
    class Calculator
    {
        public double firstNumber;
        public double secondNumber;


        public double Add()
        {

            double result = firstNumber + secondNumber;
            return result;
        }
        public double Subtract()
        {

            double result = firstNumber - secondNumber;
            return result;
        }
        public double Multiply()
        {

            double result = firstNumber * secondNumber;
            return result;
        }
        public double Divide()
        {

            double result = firstNumber / secondNumber;
            return result;
        }
    }
}
