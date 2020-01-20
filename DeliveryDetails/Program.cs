using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1.Player details of delivery \n 2.Run details of delivery");
            Console.WriteLine("Enter ur choice:");
            int ch = int.Parse(Console.ReadLine());
            Delivery d = new Delivery();
            switch (ch)
            {
             case 1:Console.WriteLine("Enter blower name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter batsman name");
                    string batsman = Console.ReadLine();
                    d.DisplayDeliveryDetails(name, batsman);
                    break;
                case 2:Console.WriteLine("Enter no of runs");
                    long runs = long.Parse(Console.ReadLine());
                    d.DisplayDeliveryDetails(runs);
                    break;
                default:Console.WriteLine("Invalid option");
                     break;
            }
            Console.ReadLine();
        }
    }
    class Delivery
    {
       public void DisplayDeliveryDetails(string bowler,string batsman)
        {
            Console.WriteLine("Blower name is:" + bowler);
            Console.WriteLine("Batsman name is:" + batsman);

        }
       public void DisplayDeliveryDetails(long runs)
        {
            if (runs == 6)
                Console.WriteLine("It is a six"+runs);
            else if (runs == 4)
                Console.WriteLine("It is a four" +runs);
            else
                Console.WriteLine("Number of runs is" + runs);
        }
    }
}
