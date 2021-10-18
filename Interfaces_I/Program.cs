using System;
using Writer;
using Calculator;

namespace Interfaces_I
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Writer
            TextWorker textWorker = new TextWorker();

            textWorker.Writer = new StandardWriter();
            textWorker.WriteText("text");

            textWorker.Writer = new BraceWriter();
            textWorker.WriteText("text");

            textWorker.Writer = new SquereWriter();
            textWorker.WriteText("text");
            #endregion

            #region Calculator
            Calculation calculation = new Calculation();

            calculation.Calculator = new Add();
            calculation.Calculate(5, 4);
            calculation.Calculator = new Multiply();
            calculation.Calculate(5, 4);
            calculation.Calculator = new Substract();
            calculation.Calculate(5, 4);
            calculation.Calculator = new Divide();
            calculation.Calculate(5, 4);
            #endregion

            Console.ReadLine();
        }
    }
}
