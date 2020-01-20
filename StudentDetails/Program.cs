using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            student st = new student();
            student st1 = new student("RAJ",12,"CSE",4,14);
            //st.Name = "Raj";
            //st.RollNo = 100;
            //st.Sem = 4;
            // st.AcceptStudentDetails();
            st.DisplayStudentDetails();
            st1.DisplayStudentDetails();
            Console.ReadLine();
        }
    }
    class student
    {
        private int rollno;
        public string name { get; set; } //autoimplemented
        private int sem;
        private string branch;
        private int mark;//read only property
        public int RollNo
        {
            get => rollno;
            set => rollno = value;
        }
        public string Name
        {
            get; 
            set;
        }
        private string Branch
        {
            get => branch;
            set => branch = value;
        }
        public int Sem
        {
            get => sem;
            set => sem = value;
        }
        private int Mark
        {
            get => mark;
        }
        public student()
        {
            this.rollno = 0;
            this.Name = "";
            this.mark = 0;
            this.sem = 3;
            this.branch = "cse";
        }
        public student(string name,int rollno,string branch,int sem,int mark)
        {
            this.Name = name;
            this.rollno = rollno;
            this.branch = branch;
            this.sem = sem;
            this.mark = mark;
        }

        public void AcceptStudentDetails()
        {
            Console.WriteLine("Enter the mark");
            this.mark = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the branch");
            this.Branch = Console.ReadLine();
            Console.ReadLine();

        }
        public void DisplayStudentDetails()
        {
            Console.WriteLine("student details aer displayed");
            Console.WriteLine(this.Name + "\n" + this.RollNo + "\n" + this.Mark + "\n" + this.sem + "\n" + this.Branch);
            Console.ReadLine();
        }
        
    }
}
