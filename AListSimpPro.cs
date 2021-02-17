using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; 

namespace Collections
{
    class AListSimpPro
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            a.Add("durga");
            a.Add("mule");
            a.Add("mahi");
            a.Add("koti");
            foreach( string s in a)
            {
                Console.WriteLine(s);
            }
            a.Sort();
            Console.WriteLine("after sorting");
            foreach(string s in a)
            {
                Console.WriteLine(s);
            }
            a.Reverse();
            Console.WriteLine("After reversing of sorted Ele");
            foreach (string s in a)
            {
                Console.WriteLine(s);
            }
        }
    }
}
