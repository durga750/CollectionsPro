using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class Employee
    {
        int id;
        string name;
        int salary;
        public Employee(int id, string name, int salary)
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
    class SortingEmpDetails
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(new Employee(1112, "gfds", 50000));
            al.Add(new Employee(5432, "jkhgf", 45000));
            al.Add(new Employee(12232, "ytr", 225000));
            al.Add(new Employee(6544, "cvbn", 43000));
            foreach(string s in al)
            {
                Console.WriteLine(s);
            }
        }
    }
}
