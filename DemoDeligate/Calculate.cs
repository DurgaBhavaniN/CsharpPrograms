using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDeligate
{
    class Calculate
    {
        public static double calArea(double r)
        {
            Console.WriteLine("cal area");
            return 3.14 * r * r;
        }
        public static double caldistance(double d)
        {
            return d*100;
        }
    }
}
