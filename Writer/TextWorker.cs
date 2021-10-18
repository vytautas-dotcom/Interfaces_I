using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Writer
{
    public class TextWorker
    {
        public IWriter Writer { get; set; }
        public void WriteText(string text)
        {
            Writer.Write(text);
        }
    }
}
