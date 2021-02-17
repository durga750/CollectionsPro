using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetPro
{
    class Employ:IComparable<Employ>
    {
        public int id;
        public string name;
        public int salary;

        public Employ(int id,string name,int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public int CompareTo(Employ other)
        {
            return this.name.CompareTo(other.name);
        }

        public override string ToString()
        {
            return $"{id}\t{name}\t{salary}";

        }
    }
    class SSetExamp
    {
        static void Main(string[] args)
        {
            SortedSet<Employ> ss = new SortedSet<Employ>();
            ss.Add(new Employ(432, "fds", 25000));
            ss.Add(new Employ(32, "ds", 250000));
            ss.Add(new Employ(43256, "fd", 50000));
            ss.Add(new Employ(76287, "tgryt", 20000));
            ss.Add(new Employ(344, "", 25000));
            foreach(Employ e in ss)
            {
                Console.WriteLine(e);
            }
          
            

        }
    }
}
