using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConvertion
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte i1 = sbyte.Parse("123");
            float f1 = float.Parse("123.3");
            decimal d1 = decimal.Parse("123.34");
            bool b = bool.Parse("true");
            
            string s = "100";
            int i = int.Parse(s);
            double d = double.Parse(s);
            long l = long.Parse(s);
            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6}", i1, f1, d1, b,i,d,l);
            Console.ReadKey();
        }
    }
}
