using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoParam
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.Add(10, 20, 67,45,56);
            
            Console.WriteLine("*****");
            Console.ReadLine();
        }
    }
    class Calculator
    {
        public void Add(params int[] x)
        {

            int res =0;
            foreach (int i in x)
                res += i;
            Console.WriteLine(res);
        }
    }
}
