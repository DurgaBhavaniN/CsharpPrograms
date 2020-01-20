using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoString
{
    class Employee
    {
        string name;
        string empid;
        int salary;
        public Employee()
        {

        }
        public Employee(string name,string empid,int salary)
        {
            this.name = name;
            this.empid = empid;
            this.salary = salary;
        }
        public override string ToString()
        {
            return "Name: "+this.name+"\n Id: "+this.empid+"\nSalary: "+this.salary;
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
