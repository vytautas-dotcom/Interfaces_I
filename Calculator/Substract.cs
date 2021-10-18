using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Substract : Calculator
    {
        public override void DoCalculation(int x, int y)
        {
            Console.WriteLine(x - y);
        }
    }
}
