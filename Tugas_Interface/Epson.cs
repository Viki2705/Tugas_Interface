using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tugas_Interface
{
    public class Epson : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Epson display dimension: 10*12");
        }

        public void Print()
        {
            Console.WriteLine("Epson printer printing...");
        }
    }
}
