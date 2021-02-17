using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Enums
    {


        enum days { sunday,monday,tuesdy=175,wednesday,thursday,friday,saturday};  
        //generallay 0 to 7 but forcingly given tuesday is 175
        static void Main(string[] args)
        {
            Console.WriteLine($"{days.saturday}=>{(int)days.saturday}");
            Console.WriteLine($"{days.tuesdy}=>{(int)days.tuesdy}");
            Console.WriteLine($"{days.monday}=>{(int)days.monday}");
        }
    }
}
