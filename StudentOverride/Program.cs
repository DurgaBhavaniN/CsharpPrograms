using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student id");
            int stuid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter studname");
            string studname = Console.ReadLine();
            Console.WriteLine("Enter exam fee");
            double examfee = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter ur choice");
            int ch = int.Parse(Console.ReadLine());
            switch(ch)
            {
                case 1:Console.WriteLine("Enter the transportfee");
                    int transportfee = int.Parse(Console.ReadLine());
                    DayScholar d = new DayScholar(stuid, studname, examfee, transportfee);
                    d.DisplayDetails();
                    Console.WriteLine("Enter the amount to be paid");
                    int amt = int.Parse(Console.ReadLine());
                    d.PayFee(amt);
                    break;
                
                case 2:Console.WriteLine("Enter the hostel fee");
                    int hostelfee = int.Parse(Console.ReadLine());
                    Hosteller h = new Hosteller(stuid, studname, examfee, hostelfee);
                    h.DisplayDetails();
                    Console.WriteLine("Enter the amount to be paid");
                    int amtt = int.Parse(Console.ReadLine());
                    h.PayFee(amtt);
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;



            }
            Console.ReadLine();
        }
    }
   abstract class Student
    {
        protected int stuid;
        protected string studname;
        protected double examfee;
       public Student(int stuid,string studname,double examfee)
        {
            this.stuid = stuid;
            this.studname = studname;
            this.examfee = examfee;
        }
       public abstract void DisplayDetails();
        public abstract void PayFee(double amt);     

    }
    class DayScholar : Student
    {
        double transportfee;
        public DayScholar(int stuid,string studname,double examfee,double transportfee):base(stuid,studname,examfee)
        {
            this.transportfee = transportfee;
        }
        public override void DisplayDetails()
        {
            Console.WriteLine("Student id " + this.stuid + "\tstudent name " + this.studname+"\texamfee "+this.examfee+"\ttransportfee"+this.transportfee);
        }
        public override void PayFee(double amt)
        {
            double bal = (examfee+transportfee)- amt;
            Console.WriteLine("Balance amount is: " + bal);
        }
    }
    class Hosteller : Student
    {
        double hostelfee;
        public Hosteller(int stuid, string studname, double examfee, double hostelfee) : base(stuid, studname, examfee)
        {
            this.hostelfee = hostelfee;
        }
        public override void DisplayDetails()
        {
            Console.WriteLine("Student id " + this.stuid + "\tstudent name " + this.studname + "\texamfee " + this.examfee + "\thostelfee" + this.hostelfee);
        }
        public override void PayFee(double eamt)
        {
            double exmbal = (examfee+hostelfee) - eamt;
            Console.WriteLine("Balance amount is: " + exmbal);
        }
    }
}
