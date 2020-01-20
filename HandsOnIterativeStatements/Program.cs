using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnIterativeStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Greet("raju");
            DispalyNaturalNos(100);
            WholeNos(100);
            DisplayEven(200);
            Console.WriteLine(ReturnFactorial(5));
            Console.WriteLine(CheckVowel('u'));
            Console.ReadKey();
        }
        public static void DisplayEven(int no)
        {
            for(int j=1;j<no;j++)
            {
                if (j % 2 == 1)
                    continue;
                Console.Write(j + "\t");
            }
            Console.ReadLine();
        }
        public static void Greet(string name)
        {
            int flag = 1;
            while (flag <= 10)
            {
                Console.WriteLine("hello " + name);
                flag++;
            }
            Console.ReadLine();
        }
        public static void DispalyNaturalNos(int i)
        {
            int flag = 1;
            while(flag<=i)
            {
                Console.Write(flag + "  ");
                flag++;
            }
            Console.ReadLine();
        }
        public static string CheckVowel(char ch)
        {
            string result = null;
            switch(ch)
            {
                case 'a':
                    result = "Vowel";
                    break;
                case 'e':
                    result = "Vowel";
                    break;
                case 'i':
                    result = "Vowel";
                    break;
                case 'o':
                    result = "Vowel";
                    break;
                case 'u':
                    result = "Vowel";
                    break;
                default:
                    result="Invalid Output";
                    break;
            }
            return result;
        }
   public static void WholeNos(int i)
       {
            int flag = 0;
            do
            {
                Console.Write(flag + "\t");
                flag++;
            } while (flag <= i);
            Console.ReadLine();
        }
        public static int ReturnFactorial(int k)
        {
            int fact = 1;
            /*for(int i=1;i<=k;i++)
             {
                 fact = fact * i;
             }*/
            int i = 1;
            for(; ;)
            {
                if (i<= k)
                    {
                        fact = fact * i;
                        i++;
                    }
                    else
                        break;
            }
            return fact;
        }
    }
}
