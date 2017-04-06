
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Stacks Ostack = new Stacks();
            Ostack.push(7);
            Ostack.push(11);
            int intStackData;
            intStackData = Ostack.Pop();
            System.Console.WriteLine(">" + intStackData);
          

        }
    }
}
