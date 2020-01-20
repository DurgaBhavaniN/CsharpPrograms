using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter choice (1.undergraduate/2.graduate);");
            int ch = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter student name:  ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter student id");
            int studentid = int.Parse(Console.ReadLine());
            switch(ch)
            {
                case 1:Console.WriteLine("Enter grade");
                       double grade = double.Parse(Console.ReadLine());
                       UnderGraduate u = new UnderGraduate();
                       Console.WriteLine(u.IsPassed(grade));
                       break;
                case 2: Console.WriteLine("Enter grade");
                       double grad = double.Parse(Console.ReadLine());
                       Graduate g= new Graduate();
                      Console.WriteLine(g.IsPassed(grad));
                       break;
                default:Console.WriteLine("Invalid option");
                    break;
            }
            Console.ReadLine();
        }
    }
    abstract class Student
    {
        protected string name;
        protected int studentid;
       public abstract Boolean IsPassed(double grade);
    }
    class UnderGraduate:Student
    {
       public override Boolean IsPassed(double grade)
        {
            if (grade > 70.0)
                return true;
            else
                return false;

        }
    }
    class Graduate : Student
    {
        public override Boolean IsPassed(double grade)
        {
            if (grade > 80.0)
                return true;
            else
                return false;
        }
    }
}
