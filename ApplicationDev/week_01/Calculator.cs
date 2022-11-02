using System;
namespace Testing
{
    public class Calculator
    {
        public double Addition(double a, double b) {
            var sum = a + b;
            return sum;
        
        }

        public double Subtraction(double a, double b) {
            var difference = a - b;
            return difference;
        }

        public double Multipication(double a, double b) {
            var multiply = a * b;
            return multiply;
        }

        public double Division(double a, double b) {
            var division = a / b;
            return division;
        }

    }

}

