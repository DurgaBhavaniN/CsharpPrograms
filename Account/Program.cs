using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the customer details");
            Console.WriteLine("Enter the account num");
            int accno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the account name");
            string aname = Console.ReadLine();
            Console.WriteLine("Enter the account type");
            string atype = Console.ReadLine();
            Console.WriteLine("Enter the amount u want to credit /debit");
            int amt = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the initial amount");
            int bal = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Transaction type ");
            char ttype = char.Parse(Console.ReadLine());
            Account a = new Account(accno, aname, atype, ttype, amt,bal);
            if (ttype == 'c' || ttype=='C')
                a.Credit(amt);
            else if (ttype == 'd' || ttype=='D')
                a.Debit(amt);
            else
                Console.WriteLine("Enter proper option");
            a.display();
            Console.ReadLine();

        }
    }
    class Account
    {
        int accno;
        static string bname;
        string aname;
        string atype;
        char ttype;
        int amt;
        int bal;
         static Account()//static constructor used to instialize only static members
        {
            bname = "SBI";
        }
        public Account(int accno,string aname,string atype,char ttype,int amt,int bal)
        {
            this.accno = accno;
            this.aname = aname;
            this.atype = atype;
            this.ttype = ttype;
            this.amt = amt;
            this.bal = bal;

        }
        public void Debit(int amt)
        {
            if(bal!=0)
            {
                bal = bal - amt;
            }
            Console.WriteLine("balance amount is "+ bal);
        }
        public void Credit(int amt)
        {
            bal = bal + amt;
            Console.WriteLine("balance amount is " + bal);
        }
        public void display()
        {
            Console.WriteLine("details are ");
            Console.WriteLine(accno + "\t" + aname + "\t" + atype + "\t" + ttype + "\t"  + bal);
        }
        
    }
}
