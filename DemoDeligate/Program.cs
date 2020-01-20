using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDeligate
{
    public delegate void delegatePointer();
    public delegate double calAreaPointer(double x);
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine();
            Program p = new Program();
            delegatePointer mydeligate = p.print;
            mydeligate += p.display;//multicast delegate
            mydeligate();
            mydeligate -= p.print;
            mydeligate();
            calAreaPointer cptr = Calculate.calArea;//create a delegate object
            
            cptr += Calculate.caldistance;//multiple return only last method wil be run
            double area = cptr(20);
            Console.WriteLine(area);
            Console.ReadLine();
        }
        public void print()
        {

            Console.WriteLine("welcome to delegate");
        }
        public void display()
        {

            Console.WriteLine("Welcome to multicast delagate");
        }
    }
}