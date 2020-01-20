using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] i = new int[4];
            i[0] = 12;
            i[1] = 20;
            i[2] = 68;
            i[3] = 40;
            //i[4] = 50;
            int k = i[2];
            Console.WriteLine(i[1]);
            //dispaly all the array elements
            for(int a=0;a<4;a++)
            {
                Console.WriteLine(i[a]);
            }
            foreach(int num in i)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}
