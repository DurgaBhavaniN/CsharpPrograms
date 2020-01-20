using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int emp_id;
            string emp_name;
            string emp_degination;
            List<Employee> IList = new List<Employee>();
            Employee et = new Employee();
            Console.WriteLine("1.Insert Employee details");
            Console.WriteLine("2.Display all Employee details");
            Console.WriteLine("3.Update Employee details based on ID");
            Console.WriteLine("4.Delete a specific Employee whose id is given");
            for(; ;)
                { 
                Console.WriteLine("Enter ur choice:");
                int ch = int.Parse(Console.ReadLine());                      
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter no.of employees wanted to insert:");
                        int n = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("Enter Employee id:");
                            emp_id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Employee name:");
                            emp_name = Console.ReadLine();
                            Console.WriteLine("Enter Employee Degination");
                            emp_degination = Console.ReadLine();
                            IList.Add(new Employee(emp_id, emp_name, emp_degination));
                        }
                        break;
                    case 2:
                        Console.WriteLine("Employee Details are");
                        foreach (Employee s in IList)
                        {
                            Console.WriteLine(s.ToString());
                        }
                        break;
                    case 3:Console.WriteLine("Updation of Employee details:");
                        IList.update();
                        break;
                    case 4:Console.WriteLine("Delete a specific Employee ");






                }
            } 



    }
    }
   class Employee
    {
        int emp_id { get; set; }
        string emp_name { get; set; }
        string emp_degination { get; set; }
            public Employee()
            {

            }
            
            
        public Employee(int emp_id,string emp_name,string emp_degination)
        {
            this.emp_id = emp_id;
            this.emp_name = emp_name;
            this.emp_degination = emp_degination;
        }
        public override string ToString()
        {
            return "Employee Name: " + this.emp_name + "\n Employee Id: " + this.emp_id + "\nEmployee Designation is: " + this.emp_degination;
        }
        
        public void update()
        {
            Console.WriteLine("Enter ID ");
            int id = int.Parse(Console.ReadLine());
            if(emp_id==id)
            {
                Console.WriteLine("Enter new values(name& degination) for update");
                string name = Console.ReadLine();
                string deg = Console.ReadLine();
                et.Add(new Employee(id, name, deg));

                    
            }
        }
        public void delete(int id)
        {
            if(emp_id==id)
            {

            }
        }

    }

}
