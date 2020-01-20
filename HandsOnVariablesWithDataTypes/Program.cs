using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnVariablesWithDataTypes
{
    class Program
    {
        string name;//instance variable
        static double salary;//static variable
        static void Main(string[] args)
        {
            int i=5;
            int[] a= new int[5] { 2, 3, 4, 5, 6 };
            Console.WriteLine(i);
            Console.WriteLine(Program.salary);
            Program obj = new Program();
            Console.WriteLine(obj.name);
            int l = 21;
            string name = "yesu raju";
            Console.WriteLine("name:{0}\n age:{1}", name, l);
            Console.ReadKey();
        }
    }
}
