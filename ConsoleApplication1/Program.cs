
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private static object intSum;

        static void Main(string[] args)
        {
            int intIndex;
            int intSum = 0;
            for (intIndex = 0; intIndex <= 10; intIndex++)
            {
                intSum = intSum + intIndex;
            }
            string strSum = System.Convert.ToString(intSum);
            Console.WriteLine(string.Format("sum is :{0} ", strSum));
            System.Console.ReadLine();
           
        }
    }
}
