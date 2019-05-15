using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            List<Group> groups = new List<Group>();
            Student a = new Student("Kolya", "Safonov", new DateTime(1999, 12, 18), 80, 13);
            Student b = new Student("Petya", "Surkov", new DateTime(1996, 05, 06), 100, 18);
            Student c = new Student("Anton", "Stepanov", new DateTime(2001, 01, 05), 60, 13);
            students.Add(a);
            students.Add(b);
            students.Add(c);
            Group aa = new Group(13, "BBI172");
            Group bb = new Group(18, "BBI174");
            groups.Add(aa);
            groups.Add(bb);

            // 1 //
            var sortStudents = from student in students
                               where student.DateOfBirth.Year >= 1999
                               orderby student.Rating descending, student.Name // descending - убывание
                               select student;

            foreach (var student in sortStudents)
            {
                Console.WriteLine($"Name - {student.Name} {student.Surname}, Date of birth - {student.DateOfBirth.ToString()}, Rating - {student.Rating}, Group Id - {student.GroupId}");
            }

            sortStudents = students
                .Where(student => student.DateOfBirth.Year >= 1999)
                .OrderByDescending(student => student.Rating)
                .ThenBy(student => student.Name);

            foreach (var student in sortStudents)
            {
                Console.WriteLine($"Name - {student.Name} {student.Surname}, Date of birth - {student.DateOfBirth.ToString()}, Rating - {student.Rating}, Group Id - {student.GroupId}");
            }

            // 2 //

            Console.WriteLine(sortStudents.FirstOrDefault().Name);
            Console.WriteLine(sortStudents.LastOrDefault().Name);
            Console.WriteLine(sortStudents.Count());

            // 3 //

            var studentgroups = students.GroupBy(student => student.Name[0]); // join?

            // Inner join
            var joinedData = (from s in students
                             join g in groups on s.GroupId equals g.Id
                             select new StudentViewModel
                             {
                                 FullName = $"{s.Name} {s.Surname}",
                                 BirthDate = s.DateOfBirth,
                                 Rating = s.Rating,
                                 Group = g.Name
                             }).ToList(); // ToArray

            joinedData = students.Join(groups, s => s.GroupId, g => g.Id,
                (s, g) => new StudentViewModel
                {
                    FullName = $"{s.Name} {s.Surname}",
                    BirthDate = s.DateOfBirth,
                    Rating = s.Rating,
                    Group = g.Name
                }).ToList();

            Func<Student, bool>[] validationRules =
            {
                s => !string.IsNullOrEmpty(s.Name),
                s => !string.IsNullOrEmpty(s.Surname),
                s => s.Rating >= 0,

            };

            var nonvalidStudents = students.Where(s => validationRules.All(r => r(s)));

            Func<Student, string>[] errorChecks =
            {
                s => string.IsNullOrEmpty(s.Name) ? "Не задано имя" : "",
                s => string.IsNullOrEmpty(s.Surname) ? "Не задана фамилия" : "",
                s => s.Rating < 0 ? "Некорректное значение рейтинга" : ""
            };

           var res = errorChecks.Aggregate("", (totalError, f) => totalError += f(a), totalError => totalError); // 1 исходное. TotalError накопленная ошибка, сначала она ""
           

            Console.ReadLine();
        }
    }
}
