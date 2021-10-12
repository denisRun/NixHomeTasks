using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            Student bab = new Student("aaaaaaaaaa", "a", "a");
            Student st2 = new Student("b", "b", "b");
            Student st3 = new Student("c", "c", "c");
            Student st4 = new Student("d", "d", "d");

            Journal j = new Journal();
            j.AddStudent(bab);
            j.AddStudent(st2);
            j.AddStudent(st3);
            j.AddStudent(st4);

            j.AddMark(bab, 70);
            j.AddMark(bab, 90);
            j.AddMark(st2, 40);
            j.AddMark(st3, 30);
            j.AddMark(st4, 65);
            j.AddMark(st4, 70);
            Console.WriteLine("Avarage mark " + j.AvgMark(bab));

            Console.WriteLine("Bad Students");
            j.BadStudents();

            Console.WriteLine("Journal");
            j.PrintJournal();
        }
    }
}
