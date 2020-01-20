using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoString
{
    class Program
    {
        static void Main(string[] args)
        {
           /* string str = "Welcome";
            Console.WriteLine(str.Length+" "+str.Replace("e","k")+" "+str.ToLower());
            Console.WriteLine(str.Contains("1c"));
           Console.WriteLine(string.Compare("hello", "Hello"));
            string str2 = "WELCOME";
            Console.WriteLine(str.Equals(str2,StringComparison.InvariantCultureIgnoreCase));
            string s1 = "cts";
            //string s = "welcome";
            Console.WriteLine(s1.ToUpper());
            Console.WriteLine(s1);
            int n = string.Compare("welcome", 3, "come", 0, 4, StringComparison.InvariantCultureIgnoreCase);
            Console.WriteLine("compare " + n);
            string input = Console.ReadLine();
            string[] data = input.Split(' ','/');
            int[] num2 = Array.ConvertAll(data, Convert.ToInt32);
            int[] num = new int[data.Length];
            for(int j=0;j<data.Length;j++)
            {
                num[j] = Convert.ToInt32(data[0]);
            }
            foreach (string val in data)
            {
                Console.WriteLine(val);
            } 
            foreach (int val in num2)
            {
                Console.WriteLine(val);
            }

            int k = 90;
            double d = 2.345;
            Console.WriteLine(k.ToString() + " " + d.ToString());
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToString("dddd/mmmm/yyyy") + dt.ToString("dddd,dd/mm/yyyy") + " " + dt.ToString("mmm,dd/mm/yyyy HH:mm:ss"));
            int[] ix = new int[] { 1, 2, 3, 4 };*/
            Employee[] eArray = new Employee[3] { new Employee("arjun", "100", 20000), new Employee("raj", "110", 30000), new Employee("venky", "120", 40000) };
           foreach (Employee e in eArray)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\n"); 
            List<Employee> elist = new List<Employee>();
            elist.Add(new Employee("arjun", "100", 20000));
            elist.Add(new Employee("raj", "110", 30000));
            elist.Add(new Employee("venky", "120", 40000));
            foreach (Employee e in eArray)
            {
                Console.WriteLine(e.ToString());
            }

            Employee e1=new Employee("arjun", "100", 20000);
            Employee e2 = new Employee("arjun", "100", 20000);
            if (e1.Equals(e2))
                Console.WriteLine("Both are same");
            else
                
                Console.WriteLine("not same employee");
            
            Console.ReadLine();
        }
    }
}
