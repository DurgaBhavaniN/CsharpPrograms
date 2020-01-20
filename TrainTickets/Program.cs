using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter passenger name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter no_of_tickets");
            int no_of_tickets = int.Parse(Console.ReadLine());
            Passanger p = new Passanger(name, age);
            p.ticketBooking(no_of_tickets);
            Console.ReadLine();
        }
    }
    public class Passanger
    {
        string name;
        int age;
        public Passanger(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public void ticketBooking(int no_of_tickets)
        {
            
                try
                {
                if (no_of_tickets > 2) throw new BookingException("cannot book more than 2 tickets");
                else
                    Console.WriteLine("Ticket booked succesfully");
                }
            catch(BookingException e )
            {
                Console.WriteLine(e.Message + e.StackTrace);
            }
        }
    }
    public class BookingException : Exception
    {
        public  BookingException(string s):base(s)
        { 
        }
    }
}
