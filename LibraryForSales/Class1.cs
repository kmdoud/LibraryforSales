using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForSales
{
    public class Class1
    {
        public Dictionary<string, int> Sales = new Dictionary<string, int>();

        public int Get(string key)
        {
            return Sales[key];
        }
        public Class1()
        {
            Sales.Add("OH", 90416);
            Sales.Add("KY", 77408);
            Sales.Add("IN", 16588);
            Sales.Add("PA", 55043);
            Sales.Add("MI", 60099);
            Sales.Add("NY", 19830);
            Sales.Add("IL", 81154);
            Sales.Add("WI", 11679);
            Sales.Add("MN", 94207);
            Sales.Add("MS", 93521);
        }
    }
}
