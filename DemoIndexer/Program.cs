using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Year = 2019;
            c[0] = "Maruthi";
            c[1] = "Benz";
            c[2] = "Honda";
            c.display();
            Console.WriteLine(c[0]);
            Console.ReadLine();
        }
    }
    class Car
    {
        int year;
        string[] name = new string[4];
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
       /* public string[] Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }*/
        public string this[int x]
        {
            get
            {
                return name
                    [x];
            }
            set
            {
                name[x] = value;
            }
                
        }
        public void display()
        {
            foreach (string val in name)
                Console.WriteLine(val);
                    }
    }
}
