using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerStatics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter palyer details");
            Console.WriteLine("Enter player name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter team name:");
            string teamname = Console.ReadLine();
            Console.WriteLine("Enter no of matches:");
            int noofmatches = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ur choice(1.Cricket player setails/2.Hockey player details):");
            int ch = int.Parse(Console.ReadLine());   
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter total runs scored and no of wickets taken");
                        int x = int.Parse(Console.ReadLine());
                        int y = int.Parse(Console.ReadLine());
                        CricketPlayer c = new CricketPlayer(name, teamname, noofmatches, x, y);
                        c.DisplayPlayerStatistics();
                        Console.WriteLine(c);
                        break;
                    case 2:
                        Console.WriteLine("Enter position and no of goals");
                        string a = Console.ReadLine();
                        int b = int.Parse(Console.ReadLine());
                        HockeyPlayer h = new HockeyPlayer(name, teamname, noofmatches, a, b);
                        h.DisplayPlayerStatistics();
                        Console.WriteLine(h);
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            

            Console.ReadLine();
        }
    }
    abstract class Player
    {
        protected string name;
        protected string teamname;
        protected int noofmatches;
        public Player(string name,string teamname,int noofmatches)
        {
            this.name = name;
            this.teamname = teamname;
            this.noofmatches = noofmatches;
        }
        public abstract void DisplayPlayerStatistics();

    }
    class CricketPlayer:Player
    {
        int totalrunscored;
        int noofwicketstaken;
        public CricketPlayer(string name,string teamname,int noofmatches,int totalrunscored, int noofwicketstaken) : base(name, teamname, noofmatches)
        {
            this.totalrunscored = totalrunscored;
            this.noofwicketstaken = noofwicketstaken;
        }
        public override void DisplayPlayerStatistics()
        {
            Console.WriteLine("Name:"+this.name + "\nscore\t" + this.totalrunscored + "\n no of wickets " + this.noofwicketstaken);
        }
    }
    class HockeyPlayer : Player
    {
        string position;
        int noofgoals;
        public HockeyPlayer(string name,string teamname,int noofmatches,string position,int noofgoals):base(name,teamname,noofmatches)
        {
            this.position = position;
            this.noofgoals = noofgoals;
        }
        public override void DisplayPlayerStatistics()
        {
            Console.WriteLine("Name  " + this.name + "\n position  " + this.position + "\n noofgoals  " + noofgoals);
        }
    }
}
