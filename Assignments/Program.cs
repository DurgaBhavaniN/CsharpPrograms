using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            display();
            Console.WriteLine("Enter ur name");
            string name = Console.ReadLine();
            Greet(name);
            Console.WriteLine("Enter two numbers");
            int a =int.Parse(Console.ReadLine());
            int b =int.Parse(Console.ReadLine());
            Range(a,b);
            Console.WriteLine("Enter  number");
            int n = int.Parse(Console.ReadLine());
            EvenOrOdd(n);
            Console.WriteLine("Enter Temperature");
            double d = double.Parse(Console.ReadLine());
            Temperature(d);
            Console.WriteLine("Series are");
            Series();
            Console.WriteLine("Enter a number for factorial");
            int f = int.Parse(Console.ReadLine());
            Fact(f);
            Console.WriteLine("Enter a number for fibnocci");
            Fibn();
            Console.WriteLine("Enter  a number for multiplication");
            int i = int.Parse(Console.ReadLine());
            MulTable(i);
            Console.WriteLine("Numbers divisible by 7 b/w 200 & 300");
            Div();
            Console.WriteLine("Enter  a 3 numbers");
            int m = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            Largest(m, l, p);
            Console.WriteLine("Enter a product num & quantity");
            int pno = int.Parse(Console.ReadLine());
            int qun = int.Parse(Console.ReadLine());
            Shopkeeper(pno,qun);

        }
        public static void display()
        {
            Console.WriteLine("Welcome to the world of C#");
            Console.ReadLine();
        }
        public static void Greet(String name)
        {
            Console.WriteLine("Hi!" + name+ "\n Welcome to the world of C#");
            Console.ReadLine();
        }
        public static void Range(int i,int j)
        {
            for(int k=i+1;k<j;k++)
            {
                Console.Write(k +" ");
            }
            Console.ReadLine();
        }
       public static void EvenOrOdd(int n)
        {
            if (n % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("odd");
            Console.ReadLine();
        }
        public static void Temperature(double f)
        {
            double c = (f - 32) * 5 / 9;
                Console.WriteLine("Temperature is "+c);
            Console.ReadLine();

        }
        public static void Series()
        {
            for(int i=0;i<=25;i++)
                {
                int t = i * i;
                Console.Write(t+" ");
                 }
            Console.ReadLine();
        }
        public static void Fact(int k)
        {
            int fact = 1;
            for(int i=1;i<=k;i++)
             {
                 fact = fact * i;
                
             }
            Console.WriteLine("factorial is" + fact);
            Console.ReadLine();
        }
        public static void Fibn()
        {
           int a = 0;
            int b = 1;
            int c=0;
            while (c <40)
            {
                 c = a + b;
                a = b;
                b = c;
                if(c<40)
                Console.Write(c+" ");
            }
            
            Console.ReadLine();
        }
        public static void MulTable(int i)
        {
            for(int j=1;j<=20;j++)
            {
                int r = i * j;
                Console.WriteLine(i+"*" + j + "=" + r);
            }
            Console.ReadLine();
        }
        public static void Div()
        {
            for(int i=200;i<=300;i++)
            {
                if (i % 7 == 0)
                    Console.WriteLine(i + " ");
            }
            Console.ReadLine();
        }
        public static void Largest(int a,int b,int c)
        {
            if (a > b && a > c)
                Console.WriteLine("Largest is" + a);
            else if(b>c)
                Console.WriteLine("Largest is" + b);
            else
                Console.WriteLine("Largest is" + c);
            Console.ReadLine();

        }
        public static void Shopkeeper(int pno, int qun)
        {
            double p1 = 22.5;
            double p2 = 44.50;
            double p3 = 9.98;
            double tprice = 0;
            switch (pno)
            {
                case 1:
                    tprice = p1 * qun;
                    Console.WriteLine("price of product 1:" + p1);
                    Console.WriteLine("Total price = " + tprice);
                    break;
                case 2:
                    tprice = p2 * qun;
                    Console.WriteLine("price of product 1:" + p2);
                    Console.WriteLine("Total price = " + tprice);
                    break;
                case 3:
                    tprice = p3 * qun;
                    Console.WriteLine("price of product 1:" + p3);
                    Console.WriteLine("Total price = " + tprice);
                    break;
                default: Console.WriteLine("Invalid Option");
                        break;
            }
            Console.ReadLine();
        }
        public static void Smallest(int a,int b,int c,int d,int e)
        {

        }

    }
}
