using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SetPro
{
    class NameComp : IComparer
    {
        public int Compare(object x, object y)
        {
            Student1 stu1 = (Student1)x;
            Student1 stu2 = (Student1)y;
            return stu1.name.CompareTo(stu2.name);
        }
    }

    public class Student1
    {
        public int id;
        public string name;
        public int Marks;

        public  Student1(int id,string name,int Marks)
        {
            this.id = id;
            this.name = name;
            this.Marks = Marks;
        }

        public override string ToString()
        {
            return $"{id}\t{name}\t{Marks}";
        }
    }
    class SortAlStudent
    {
        static void Main(string[] args)
        {
           ArrayList  l = new ArrayList();
            l.Add(new Student1(123,"jhgfds",87));
            l.Add(new Student1(5432, "cvbnm", 95));
            l.Add(new Student1(3354, "uytr", 90));
            l.Add(new Student1(234, "cbnb", 75));
           
            foreach (Student1 s in l)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("After sorting");
            l.Sort(new NameComp());
           foreach(Student1 s in l)
            {
                Console.WriteLine(s);
            }
        }
    }
}
