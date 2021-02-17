using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Collections
{
    class Employee1
    {
        int id;
        string name;
        int salary;
        public Employee1(int id,string name,int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public override string ToString()
        {
            return $"{id}\t{name}\t{salary}";
        }
    }
    class EmpDetailsAList
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(new Employee1(121, "gfd", 50000));
            al.Add(new Employee1(12, "jhgf", 55000));
            al.Add(new Employee1(1213456, "mnbvcx", 10000));
            foreach (Employee1 e in al)
            {
                Console.WriteLine(e);
            }
            

        }
    }
}
