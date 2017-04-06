using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Stacks
    {
        private int intIndex = -1;
        private System.Collections.ArrayList Array = new System.Collections.ArrayList();

        public void push(int Data)
        {
            intIndex++;
            Array.Add(Data);
        }

        public int Pop()
        {
            if (intIndex >= 0)
            {
                
                for (intIndex = 0; intIndex < Array.Capacity - 1; intIndex++)
                {
                    int intData = (int)Array[intIndex];
                    Array.RemoveAt(intIndex);
                    return (intData);
                }
            }
            else
            {
                return (-1);
            }
        }
    }
}
