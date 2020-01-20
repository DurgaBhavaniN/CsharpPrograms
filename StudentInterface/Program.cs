using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter student id");
            int studid = int.Parse(Console.ReadLine());
            DayScholar ds = new DayScholar(studid, name);
            ds.showDetails();
            Resident r = new Resident(studid, name);
            r.showDetails();
            Console.ReadLine();

        }
    }
   public interface IStudent
    {
         int studid { get; set; }
        string name { get; set; }
        
      void showDetails(); 

    }
    class DayScholar : IStudent
    {
        int studid;
        string name;
        int IStudent.studid{get;set;}
        string IStudent.name{ get;set;}
        /* int Studid;string Name;
         * int IStudent.studid{get{return  Studid;}set{Studid=value;}
          int IStudent.name{get{return  Name;}set{Name=value;}*/
        public DayScholar(int studid, string name)
        {
            this.studid = studid;
            this.name = name;
        }
        public void showDetails()
        {
            Console.WriteLine("Student name is: " + this.name + "\n Student Id is : " + this.studid+"\n");
        }

    }
    class Resident:IStudent
    {
        int studid;
        string name;
        int IStudent.studid { get; set; }
        string IStudent.name { get; set; }

        public Resident(int studid, string name)
        {
            this.studid = studid;
            this.name = name;
        }
        public void showDetails()
        {
            Console.WriteLine("Student name is: " + this.name + "\n Student Id is : " + this.studid);
        }

    }
}
