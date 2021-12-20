using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppgifterFrånPresentationer
{
    public class Student
    {
        public Student(string fname, string lname, int age)
        {
            Fname = fname;
            Lname = lname;
            Age = age;
        }

        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }

        public static IEnumerable<Student> SortName(Student[] stud)
        {
            return from student in stud 
                   where string.Compare(student.Fname, student.Lname) < 0 
                   select student;
        }

        public static IEnumerable<Student> BetweenAge(Student[] stud)
        {
            return from student in stud
                   where student.Age<24 && student.Age > 18
                   select student;
        }

        public static IEnumerable<Student> SortStudents(Student[] stud)
        {
            Console.WriteLine("Without LINQ:");

            stud.OrderBy(x => x.Fname).ThenBy(x => x.Lname);
            foreach (var e in stud)
            {
                Console.WriteLine(e.Fname+"   "+e.Lname);
            }
            Console.WriteLine();
            Console.WriteLine("With LINQ:");

            return from student in stud
                   orderby student.Fname, student.Lname
                   select student;
        }
    }
}
