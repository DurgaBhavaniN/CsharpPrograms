using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace JaggedPratice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] n = new int[2][];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter column size");
                int size = int.Parse(Console.ReadLine());
                n[i] = new int[size];
            }
            for (int i = 0; i < 2; i++)//array reading
            {
                for (int j = 0; j < n[i].Length; j++)
                {
                    n[i][j] = int.Parse(Console.ReadLine());
                }
            }
            int sum = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < n[i].Length; j++)
                {

                    for (int k = j; k < n[i].Length; k++)
                    {
                        if (n[i][j] == n[i][k + 1])
                            sum = n[i][j] + n[i][k + 1];
                    }
                }
            }

            Console.WriteLine("sum is " + sum);
            Console.ReadLine();
    }
    }
}
