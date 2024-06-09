using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Tugas_Interface
{
    public class Canon : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Canon display dimension: 9.5*12");
        }

        public void Print()
        {
            Console.WriteLine("Canon printer printing...");
        }
    }
}