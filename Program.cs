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

            Student studentSvat = new Student("a", "a", "a");
            Student st2 = new Student("b", "b", "b");
            Student st3 = new Student("c", "c", "c");
            Student studentRab = new Student("d", "d", "d");

            Journal j = new Journal();
            j.AddStudent(studentSvat);
            j.AddStudent(st2);
            j.AddStudent(st3);
            j.AddStudent(studentRab);

            j.AddMark(studentSvat, 70);
            j.AddMark(studentSvat, 90);
            j.AddMark(st2, 40);
            j.AddMark(st3, 30);
            j.AddMark(studentRab, 65);
            j.AddMark(studentRab, 70);
            Console.WriteLine("Avarage mark " + j.AvgMark(studentSvat));

            Console.WriteLine("Bad Students");
            j.BadStudents();

            Console.WriteLine("Journal");
            j.PrintJournal();
        }
    }
}
