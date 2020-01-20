using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DemoDelegate2
{
    class Program
    {
        public delegate double calAreaPointer(double x);

        static void Main(string[] args)
        {
            //anonymous method
            calAreaPointer cptr = new calAreaPointer(delegate (double r) { return 3.14 * r * r; });
            //above code you can simplify wih lambda
            calAreaPointer cptr1 = (r => 3.14 * r * r);
            double area1 = cptr1(10);
            Console.WriteLine(area1);
            double area = cptr(12);
            Console.WriteLine(area);
            //prebuild delegates Func<>,Action<>,Predicate<>
            Func<double, double> f1 = (r => 3.14 * r * r);
            double area2 = f1(14);
            Console.WriteLine(area2);
            Action<string> act = (y => Console.WriteLine(y));
            act("Welcome");
            Predicate<string> pt = (y => y.Length > 3);
            Console.WriteLine(pt("chennai"));
            int[] array = new int[] { 1, 3, 4, 5 };
            List<string> names = new List<string>();
            names.Add("ajay");
            names.Add("raj");
            names.Add("sai");
            int x= array.Count(a1 => a1 > 2);
            Console.WriteLine(x);
            List<string> sn = names.FindAll(y => y.Contains('y'));
            foreach(string n in sn)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
       /* public static double calArea(double r)
        {
            return 3.14 * r * r;
        }*/
    }
}
