using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class EnumMonths
    {
        enum months { january, feb, march=200, april, may, june, july, aug, sep, oct, nov, dec };

        static void Main(string[] args)
        {
            Console.WriteLine($"{months.feb}=>{(int)months.feb}");
            Console.WriteLine($"{months.may}=>{(int)months.may}");
            Console.WriteLine($"{months.january}=>{(int)months.january}");
            Console.WriteLine($"{months.sep}=>{(int)months.sep}");
        }
    }
}
