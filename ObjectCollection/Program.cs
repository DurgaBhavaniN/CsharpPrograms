using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee e = new Employee();
            List<Employee> elist = new List<Employee>();
            elist.Add(new Employee("Raj", "111", 10000));
            elist.Add(new Employee("gagan", "121", 20000));
            elist.Add(new Employee("arjun", "131", 30000));
            elist.Add(new Employee("venky", "141", 12000));
            List<Employee> highpay = elist.FindAll(e => e.salary > 12000);
            foreach (Employee e1 in highpay)
            {
                Console.WriteLine(e1);
            }
            Console.ReadLine();
        }
    }
    class Employee
    {
        string name;
        string empid;
        public int salary;
        public Employee()
        {

        }
        public Employee(string name, string empid, int salary)
        {
            this.name = name;
            this.empid = empid;
            this.salary = salary;
        }
        public override string ToString()
        {
            return "Name: " + this.name + "\n Id: " + this.empid + "\nSalary: " + this.salary;
        }
        public override bool Equals(object obj)
        {
            Employee tmp = (Employee)obj;
            if (this.empid == tmp.empid && this.name == tmp.name)
                return true;

            else
                return false;
        }

    }
}
