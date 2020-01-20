using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            ICICI ch = new ICICI("ICICI", "Chennai", "RAJ");
            SBI sb = new SBI("SBI", "hyderabad", "hanvi");
            ch.displaydetails();
            ch.getInterest();
            ch.displayDemat();
            sb.getgoldinterest();
            sb.displaydetails();
            sb.getInterest();
            Console.ReadLine();
        }
    }
    interface ILoan
    {
        void getInterest();        
    }
    interface IGloan : ILoan
    {
        void getgoldinterest();
    }
    interface IDmat 
    {
        void displayDemat();
    }
    public abstract class  Bank
    {
        protected string loc;
        protected string bname;
        public Bank(string bname,string loc)
        {
            this.bname = bname;
            this.loc = loc;
        }

    }
    public class SBI:Bank,IGloan
    {
        string bmanager;
        public SBI(string bname,string loc,string bmanager):base(bname,loc)
        {
            this.bmanager = bmanager;
        }
        public void getInterest()
        {
            Console.WriteLine("sbi loan interest rate is 12%");
        }
        public void getgoldinterest()
        {
            Console.WriteLine("sbi gold loan interest rate is 22%");
        }
        public void displaydetails()
        {
            Console.WriteLine(this.bname + " " + this.loc+ " " + this.bmanager);
        }
    }
    public class ICICI: Bank,ILoan,IDmat//one class can implement multiple interfaces
    {
        string bhead;
        public ICICI(string bname, string loc, string bhead) : base(bname, loc)
        {
            this.bhead = bhead;
        }
        public void getInterest()
        {
            Console.WriteLine("ICICI loan interest rate is 17%");
        }
        
        public void displayDemat()
        {
           
                Console.WriteLine("SBI can starts the demart accounts");
            
        }
        public void displaydetails()
        {
            Console.WriteLine(this.bname + " " + this.loc + " " + this.bhead);
        }
    }
}
