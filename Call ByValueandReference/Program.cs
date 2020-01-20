using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Call_ByValueandReference
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int result = cal.Add(x,y);
            Console.WriteLine(result);
                // cal.Add(25,56);
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            cal.Swap(ref a,ref b);
            Console.WriteLine("after swapping  "+ a + "\t" + b);
            cal.Subtract(x, y, out int sub);
            Console.WriteLine(sub);
            Console.ReadLine();
        }
    }
}
class Calculator
{
    int val1;
    int val2;
    public int Val1
    {
        get => val1;
        set => val1 = value;
    }
    public int Val2
    {
        get => val2;
        set => val2 = value;
    }
    public Calculator()
    {

    }
    public Calculator(int val1,int val2)
    {
        this.val1 = val1;
        this.val2 = val2;
    }
    public int Add(int num1,int num2)
    {
        return num1 + num2;
        //Console.WriteLine(num1 + num2);
    }
    public int Subtract(int num1,int num2,out int res)
    {
        res = num1 - num2;
        return res;
    }
    public void Swap(ref int num1,ref int num2)
    {            
        int tmp = num1;
        num1 = num2;
        num2 = tmp;
        Console.WriteLine(num1);
        Console.WriteLine(num2);
    }
}
