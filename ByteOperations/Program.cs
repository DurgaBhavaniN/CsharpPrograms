using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 10;
            byte b1 = (byte)(b + 10);
            Console.WriteLine(b1);
            Console.ReadKey();
        }
    }
}
