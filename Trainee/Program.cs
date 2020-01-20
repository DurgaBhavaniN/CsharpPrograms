using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ente no.of trainees");
            List<Trainee> lt = new List<Trainee>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter trainer id");
                int trainee_id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter trainer name");
                string trainee_name = Console.ReadLine();
                Console.WriteLine("Enter project id");
                int project_id = int.Parse(Console.ReadLine());
                Trainee t = new Trainee(trainee_id, trainee_name, project_id);
                lt.Add(new Trainee(trainee_id, trainee_name, project_id));

            }
            List<Trainee> pd = lt.FindAll(p => p.project_id != -1);
            foreach(Trainee e in pd)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
        public class Trainee
        {
            int trainee_id;
            string trainee_name;
           public  int project_id;
            
            public Trainee(int trainee_id, string trainee_name, int project_id)
            {
                this.trainee_id = trainee_id;
                this.trainee_name = trainee_name;
                this.project_id = project_id;
            }
            public  override string ToString()
            {
                return ("Name: " + trainee_name + "\nTrainee ID: " +trainee_id + "\nProject_ID: " + project_id);
            }


        }
    }
}
