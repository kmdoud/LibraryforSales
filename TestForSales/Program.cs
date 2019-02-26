using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForSales
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryForSales.Class1 inst = new LibraryForSales.Class1();
            var salestotal = inst.Get("IN") + inst.Get("NY") + inst.Get("MN");
            Console.WriteLine($"Sales for IN, NY, MN = {salestotal}");

            salestotal = inst.Get("KY") + inst.Get("PA") + inst.Get("MI") + inst.Get("IL");
            Console.WriteLine($"Sales for KY, PA, MI, IL ={salestotal}");
        }
    }
}
