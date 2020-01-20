using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPartial
{
   partial class ClassA
    {
        partial void setData()
        {
            Console.WriteLine("Data is assigned using partial");

        }
    }
}
