using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Child:Parent
    {
       new public int Add(int x,int y,int z)
        {
            Console.WriteLine(x+y+z);
            return (x + y + z);
        }
    }
}
