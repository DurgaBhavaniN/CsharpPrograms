using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a num");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("1.Even or Odd");
            Console.WriteLine("2.Natural Numbers");
            Console.WriteLine("3.multiplication table");
            //Console.WriteLine("Enter ur choice");
            int ch = int.Parse(Console.ReadLine());
            Menu(i,ch);
        }
        public static void Menu(int i,int ch)
        {


            // Console.WriteLine("Enter ur choice");
            //string result = null;
            while (ch != 0)
            {
                Console.WriteLine("Enter ur choice");
                //int ch = int.Parse(Console.ReadLine());
                int flag = 1;
                switch (ch)
                {
                    case 1:
                        if (i % 2 == 0)
                            Console.WriteLine("even");
                        else
                            Console.WriteLine("odd");
                        Console.ReadLine();
                        break;
                    case 2:
                        while (flag <= i)
                        {
                            Console.WriteLine(flag + " "); ;
                            flag++;
                        }
                        Console.ReadLine();
                        break;
                    case 3:
                        for (int j = 1; j <= i; j++)
                        {
                            int k = i * j;
                            Console.WriteLine(i + "*" + j + "=" + k);
                        }
                        Console.ReadLine();
                        break;
                    case 4: break;
                    default:
                        Console.WriteLine("Invalid Option");
                        Console.Read();
                        break;

                }
            }
            }
            
    }
}
