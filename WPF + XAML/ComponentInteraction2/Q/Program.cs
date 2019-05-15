using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Q
{
    class Program
    {
        static void Main(string[] args)
        {
            var json = new JsonSerializer();
            List<Group> groups;
            List<Student> students;

            using (var sr = new StreamReader("../../Data/Grops.json"))
            {
                using (var jsonReader = new JsonTextReader(sr))
                {
                    groups = json.Deserialize<List<Group>>(jsonReader);
                }
            }

            using (var sr = new StreamReader("../../Data/Students.json"))
            {
                using (var jsonReader = new JsonTextReader(sr))
                {
                    students = json.Deserialize<List<Student>>(jsonReader);
                }
            }

            ShowStudents(SQLLikegetStudents(students));
            //ShowStudents(LamdaAndMethodsGetStudent(students));

            GroupStudents(students);

            Console.ReadLine();

          


        }

        static IEnumerable<Student> SQLLikegetStudents(IEnumerable<Student> students)
        {
            return from s in students
                   where s.DateOfBirth.Year >= 1998
                   orderby s.Rating descending, s.Name
                   select s; // s odna stroka
        }

        static IEnumerable<Student> LamdaAndMethodsGetStudent(List<Student> students)
        {
            return students.Where(s => s.DateOfBirth.Year >= 1998).OrderByDescending(r => r.Rating).ThenBy(s => s.Name);
        }

        static void ShowStudents(IEnumerable<Student> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name} {student.Surname} born {student.DateOfBirth} rating {student.Rating} ");
            }
        }

        static void GroupStudents(List<Student> students)
        {
            var groups = students.GroupBy(s => s.Name[0]);
            foreach ( var group in groups)
            {
                Console.WriteLine($"Name starts with {group.Key}");
                foreach (Student student in group)
                {
                    Console.WriteLine(student.Name);
                } 
            }
        }

        static void JoinStudentsWgrouos(List<Student> students, List<Group> groups)
        {
            var result = from s in students
                         join g in groups on s.GroupId equals g.Id
                         select new
                         {
                             Name = $"{s.Name} {s.Surname}",
                             GN = g.Number,
                             Rating = s.Rating
                         };
            foreach (var r in result)
            {
                Console.WriteLine($"{r.Name} {r.GN} {r.Rating}");
            }
        }

        static void LambdaAndLinqJoinStudentWgroups(List<Student> students, List<Group> groups)
        {
            var result = students.Join(groups, g => g.GroupId, G => G.Id, (s, g) => new { Student = s, Group = g }).Select(a => $"{a.Student.Name} {a.Group.Number}");
            foreach (var r in result)
            {
                Console.WriteLine(r);
            }
        }
    }
}
