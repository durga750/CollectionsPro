using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetPro
{
    class Student
    { 
        public int id { get; set; }
        public string name { get; set; }
        public int Marks { get; set; }

       
       
        public override string ToString()
        {
            return $"{id}\t{name}\t{Marks}";
        }
    }
    class LStudent
    {
        static void Main(string[] args)
        {
            List<Student> l = new List<Student>();
            l.Add(new Student() { id = 213, name = "dhfgjk", Marks = 97 });
            l.Add(new Student() { id = 1324, name = "ertyu", Marks = 85 });
            l.Add(new Student() { id = 8685, name = "bvvvvv", Marks = 100 });
            foreach(Student s in l)
            {
                Console.WriteLine(s);
            }
           
        }
    }
}
