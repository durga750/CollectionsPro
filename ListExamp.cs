using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetPro
{
    class ListExamp
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>();
            l.Add(56666666);
            l.Add(32434);
            l.Add(1234);
            l.Add(54356);
            foreach(int i in l )
            {
                Console.WriteLine(i);
            }
        }
    }
}
