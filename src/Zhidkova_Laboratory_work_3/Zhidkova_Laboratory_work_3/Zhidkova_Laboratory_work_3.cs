using System;

namespace Zhidkova_Laboratory_work_3
{
    internal class Zhidkova_Laboratory_work_3
    {
        static void Main(string[] args)
        {
        }
    }

    public class Calculator
    {
        public double Division(double number1, double number2)
        {
            if (number2 == 0.0D)
                throw new DivideByZeroException();
            return number1 / number2;
        }

        public double Amount(double number1, double number2)
        {
            return number1 + number2;
        }
    }
}
