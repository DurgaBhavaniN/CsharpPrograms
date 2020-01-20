using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] names = new string[3][];
            for(int i=0;i<3;i++)
            {
                Console.WriteLine("Enter size");
                int size = int.Parse(Console.ReadLine());
                names[i] = new string[size];
            }
            for(int i=0;i<3;i++)//array reading
            {
                for(int j=0;j<names[i].Length;j++)
                {
                    names[i][j] = Console.ReadLine();
                }
            }
            for (int i = 0; i < 3; i++)//displaying
            {
                for (int j = 0; j < names[i].Length; j++)
                {
                    Console.WriteLine(" "+names[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            foreach (string x in names[1])
                Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
