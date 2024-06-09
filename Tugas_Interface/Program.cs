using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPrinterWindows printer;

            Console.WriteLine("Pilih Printer");
            Console.WriteLine("1. Epson ");
            Console.WriteLine("2. Canon ");
            Console.WriteLine("3. LaserJet\n");
            Console.Write("Nomor Printer [1..3]: ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            switch (nomorPrinter)
            {
                case 1:
                    printer = new Epson();
                    break;
                case 2:
                    printer = new Canon();
                    break;
                case 3:
                    printer = new LaserJet();
                    break;
                default:
                    printer = null;
                    break;
            }

            if (printer != null)
            {
                printer.Show();
                printer.Print();
            }
            else
            {
                Console.WriteLine("Nomor printer tidak valid.");
            }
        }
    }
}

