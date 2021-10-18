using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculation
    {
        public Calculator Calculator { get; set; }
        public void Calculate(int x, int y)
        {
            Calculator.DoCalculation(x, y);
        }
    }
}
