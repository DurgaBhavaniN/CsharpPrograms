using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // A obj = new A();
            A obj;
           // obj.display();
            obj = new B();
            obj.display();
            C obj2 = new C();
            obj2.display();

          /*  A obj = new A();
            obj.display();
            B obj1 = new B();
            obj1.display();
            C obj2 = new C();
            obj2.display();*/


           /* Shape picture = new Shape();
            picture.draw();
            picture.draw(2);
            picture.draw(2,4);
            picture.draw(2, 4,7);
            picture.draw(3,5,6,"raj");*/
            Console.ReadLine();
        }
    }
    /*class Shape
    {
        int length;
        int width;
        int breadth;
        public void draw()
        {
            Console.WriteLine("A shape can be drawn");
        }
           public void draw(int l)
        {
            Console.WriteLine("A square can be drawn");
        }
        public void draw(int l,int w)
        {
            Console.WriteLine("A rectangle can be drawn");
        }
        public void draw(int l, int w,int d)
        {
            Console.WriteLine("A box can be drawn");
        }
        public void draw(int l,int d,int w,string name)
        {
            Console.WriteLine(name+ "   can be drawn");
        }*/

    
    abstract class A
    {
        //public virtual void display()
        //{
        //    Console.WriteLine("display A class details");
        //}
        public abstract void display();
    }
    class B:A
    {
        public override void display()
        {
            Console.WriteLine("display B class details");
        }
    }
    class C:A
    {
        public override void display()
        {
            Console.WriteLine("display C class details");
        }
    }
}
