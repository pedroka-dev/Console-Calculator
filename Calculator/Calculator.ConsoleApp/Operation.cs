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
        public string OperationType;
        public double Result;

        public Operation(double numberA, double numberB, string operationType, double result)
        {
            this.NumberA = numberA;
            this.NumberB = numberB;
            this.OperationType = operationType;
            this.Result = result;
        }

        public string AttributesToString()
        {
            return $"`{this.NumberA} {this.OperationType} {this.NumberB} = {this.Result}";
        }
    }
}
