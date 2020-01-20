using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int high, low;
            Console.WriteLine("Enter the size of an array");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the elements into array");
            int[] a = new int[size];
            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine("ENTER a[{0}]:", i);
                a[i] = int.Parse(Console.ReadLine());

            }
            high = a[0];
            low = a[0];
            for (int i=0;i<size;i++)
            {
                if (a[i] > high)
                    high = a[i];
                if (a[i] < low)
                    low = a[i];
            }
            Console.WriteLine("Highest is "+high + "\n Lowest is " + low);
            Console.ReadLine();
        }
    }
}
