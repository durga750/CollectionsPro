using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SetPro
{
        class Employee1:IComparable<Employee1>
        {
            int id;
            string name;
            int salary;
            public Employee1(int id, string name, int Marks)
            {
                this.id = id;
                this.name = name;
                this.salary = Marks;
            }

        public int CompareTo(Employee1 other)
        {
            if(this.salary<other.salary)
            {
                return -1;
            }
            if(this.salary>other.salary)
            {
                return 1;
            }
            return 0;
        }

        //public int CompareTo(Employee1 other)
        //{
        //    if (this.id < other.id)
        //    {
        //        return -1;
        //    }
        //    if(this.id>other.id)
        //    {
        //        return 1;
        //    }
        //    return 0;
        //}

        public override string ToString()
            {
                return $"{id}\t{name}\t{salary}";
            }
        }
        class SetStudents
        {
            static void Main(string[] args)
            {
                SortedSet<Employee1> ss = new SortedSet<Employee1>();
                ss.Add(new Employee1(1112, "gfds", 50000));
                ss.Add(new Employee1(5432, "jkhgf", 45000));
                ss.Add(new Employee1(12232, "ytr", 225000));
                ss.Add(new Employee1(6544, "cvbn", 43000));
                foreach (Employee1 emp in ss)
                {
                    Console.WriteLine(emp);
                }
            }
        }
}
