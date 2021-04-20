using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ConsoleApp
{
    class Operation
    {
        public double NumberA;
        public double NumberB;
        public char OperationType;
        public double Result;

        public Operation(double numberA, double numberB)
        {
            this.NumberA = numberA;
            this.NumberB = numberB;
        }

        public void Subtraction()
        {
            Result = NumberA - NumberB;
            OperationType = '-';
        }
        
        public void Addition()
        {
            Result = NumberA + NumberB;
            OperationType = '+';
        }

        public void Multiplication()
        {
            Result = NumberA * NumberB;
            OperationType = '*';
        }
        
        public void Division()
        {
            if (NumberB == 0)
                throw new DivideByZeroException();

            Result = NumberA / NumberB;
            OperationType = '/';
        }
        public string AttributesToString()
        {
            return $"`{this.NumberA} {this.OperationType} {this.NumberB} = {this.Result}";
        }
    }
}
