using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arraylists
            Console.WriteLine("arraylists");
            ArrayList a1 = new ArrayList();
            a1.Add(5);
            a1.Add("raju");
            a1.Add(2.33);
            a1.Add('d');
            foreach (var val in a1)
                Console.WriteLine(val);
            a1.Remove(2.33);
            foreach (var val in a1)
                Console.WriteLine(val);
            Console.WriteLine("***********");

            //non generic Queue
            Console.WriteLine("Queue");
            Queue qlist = new Queue();
            qlist.Enqueue(1);
            qlist.Enqueue("raj");
            qlist.Enqueue('r');
            Console.WriteLine("removed element is" + qlist.Dequeue());
            foreach (var val in qlist)
                Console.WriteLine(val);
            Console.WriteLine("***********");

            Console.WriteLine("Stack");
            Stack slist = new Stack();
            slist.Push(23);
            slist.Push("hello");
            slist.Push(23.122);
            Console.WriteLine(slist.Pop());
            Console.WriteLine(slist.Peek());
            foreach (var s in slist)
                Console.WriteLine(s);
            Console.WriteLine("***********");

            Console.WriteLine("Hash table");
            Hashtable ht = new Hashtable();
            ht.Add(1, "raj");
            ht.Add("a", 1000);
            ht.Add("t1", 30);
            foreach (var h in ht.Keys)
            {
                Console.WriteLine(h);
                Console.WriteLine(ht[h]);
             }
            Console.WriteLine("***********");

            Console.WriteLine("List");
            List <int> list=new List<int>();
             list.Add(10);
            list.Add(10);
            list.Add('a');
            list.Add(34);
            foreach (int val in list)
                Console.WriteLine(val);
            Console.WriteLine("***********");

            HashSet<int> hs = new HashSet<int>();
            Console.WriteLine("Hash set");
            hs.Add(10);
            hs.Add(20);
            hs.Add(47);
            foreach (int val in hs)
                Console.WriteLine(val);
            Console.WriteLine("***********");

            Console.WriteLine(" generic queue");
            Queue<string> gqlist = new Queue<string>();
            gqlist.Enqueue("1");
            gqlist.Enqueue("arun");
            gqlist.Enqueue("c");
            Console.WriteLine(gqlist.Dequeue());
            foreach (var val in gqlist)
                Console.WriteLine(val);
            Stack<float> gslist = new Stack<float>();
            gslist.Push(23);
            gslist.Push(12.234f);
            gslist.Push(23.123f);
            Console.WriteLine(gslist.Pop());
            Console.WriteLine(gslist.Peek());
            foreach (var s in gslist)
                Console.WriteLine(s);
            Console.WriteLine("***********");

            Console.WriteLine("Dictionary");
            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(1, "Raj");
            dt.Add(2, "radha");
            dt.Add(3, "lakshmi");
            foreach(KeyValuePair<int,string> kl in dt)
            {
                Console.WriteLine(kl.Key);
                Console.WriteLine(kl.Value);
            }
            Console.ReadLine();








            Console.ReadLine();
        }
    }
}
