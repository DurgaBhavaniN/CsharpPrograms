using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] marks = new int[5, 3];
            for(int i=0;i<5;i++)
            {
                for(int j=0;j<3;j++)
                {
                    marks[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i <5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" "+marks[i, j]);
                }
                Console.WriteLine();
            }
           foreach (int x in marks)
                Console.Write(x + " ");
            Console.ReadLine();
            int topscore = 0;
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<5;j++)
                {
                    if (j == 0)
                        topscore = marks[j, i];
                    else
                    {
                        if (marks[j, i] > topscore)
                            topscore = marks[j, i];
                    }
                }
                Console.WriteLine("highest for subject" + (i + 1) + " is" + topscore);
            }
            Console.ReadKey();
        }
    }
}
