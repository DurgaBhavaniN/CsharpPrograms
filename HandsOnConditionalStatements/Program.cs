using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a num");
            int i = int.Parse(Console.ReadLine());
            double j = double.Parse(Console.ReadLine());
            double k = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double n = double.Parse(Console.ReadLine());
            string result = EvenOrOdd(i);
            Console.WriteLine(result);
            Console.WriteLine(Max(12, 23, 11));
            // Console.WriteLine(Result(56, 67, 78, 89, 35));
            Console.WriteLine(Result(j, k, l, m, n));
            Console.ReadLine();
        }
        public static string EvenOrOdd(int i)
        {
            if (i % 2 == 0)
            {
                return "even";
            }
            else
            {
                return "odd";
            }
        }
        public static int Max(int i,int j,int k)
        {
            if(i>j)
            {
                if (i > k)
                    return i;
                else
                    return k;
            }
            else
            {
                if (j > k)
                    return j;
                else
                    return k;
            }
        }
        public static string Result(double m1,double m2,double m3,double m4,double m5)
        {
            double avg = (m1 + m2 + m3 + m4 + m5) / 5;
            if (avg >= 70)
                return "Distinction with" + avg + "%";
            else if(avg>=60 && avg<70)
                return "First Class with" + avg + "%";
            else if (avg >= 50 && avg < 60)
                return "Second Class with" + avg + "%";
            else return "Fail";
        }
    }
}
