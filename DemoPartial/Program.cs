using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPartial
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassA obj = new ClassA();
            obj.print();
            Console.ReadLine();
        }
    }
    partial class ClassA//partial method can be created only in partial class
    {
        partial void setData();//partial method declaration
        public void print()
        {
            Console.WriteLine("ClassA Printing");
            setData();//partial method should be private
        }

    }
}
