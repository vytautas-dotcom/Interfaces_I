using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Writer
{
    public class BraceWriter : IWriter
    {
        public void Write(string text)
        {
            Console.WriteLine("{"+text+"}");
        }
    }
}
