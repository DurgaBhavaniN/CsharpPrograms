using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Demo4
    { 
        static void Main()
        {
            string[] names = new string[8] { "Raju", "Sai", "Swathi", "Anju", "Lohi", "Lilly", "Blessey", "Honey" };
            Console.WriteLine("Enter the search name");
            string num = Console.ReadLine();
            int flag = 0,i=1;
            foreach (string s in names)
            {
                if (s == num)
                {
                    flag = 1;
                    break;

                }
                i++;
            }
            if (flag == 1)
                Console.WriteLine("Element found in " + i);
            else
                Console.WriteLine("Element not found");
            Console.ReadKey();
        }

      }
}
