using System;

namespace DemoException
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("RAJ", "100", 0);
           // int salary = int.Parse(Console.ReadLine());
            try
            {
                if (emp.sal == 0) throw new salaryException("Salary cannot be zero");
            }
            catch (salaryException e)
            {
                Console.WriteLine(e.Message + e.StackTrace);
            }
        }
    }

     public class salaryException : Exception
    {
            public salaryException(string s) : base(s)
            { }
    }
    public class Employee
    {
        string name;
        string id;
        public int sal;
        public Employee(string name, string id, int sal)
        {
            this.name = name;
            this.id = id;
            this.sal = sal;

        }
    }
}
