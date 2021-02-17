using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetPro
{
    class SetExamp
    {
        static void Main(string[] args)
        {
            SortedSet<int> ss = new SortedSet<int>();
            ss.Add(654);
            ss.Add(213456);
            ss.Add(1236);
            ss.Add(654);
            ss.Add(8762);                //unordered and dupli not allowed
            foreach (int i in ss)
            {
                Console.WriteLine(i);
            }
        }
    }
}
