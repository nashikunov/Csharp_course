using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace seminar3
{
    internal class Program
    {

        static void OutputEmployees(List<Employee> employees)
        {
            foreach (var e in employees)
                Console.WriteLine($"{e.Name} born {e.Birthdate:d} salary={e.Salary}"); // d без времени
        }

        static decimal AverageSalary(List<Employee> employees)
        {
            decimal sum = 0;
            foreach (var employee in employees)
            {
                sum += employee.Salary;
            }
            return sum / employees.Count;
        }

        static List<Employee> YoungEmployees(List<Employee> employees)
        {
            List<Employee> result = new List<Employee>();
            foreach (var e in employees)
            {
                if (e.Birthdate.Year >= 1997)
                    result.Add(e);
            }
            return result;



        }
        
        static Employee InputEmployee()
        {
            string name;
            DateTime birthdate = new DateTime();
            decimal salary;
            
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
                return null;

            bool isCorrect = false;

            do
            {

                Console.WriteLine("Enter birthdate:");
                try
                {
                    birthdate = DateTime.Parse(Console.ReadLine());
                    isCorrect = true;
                }
                catch
                {
                    Console.WriteLine("Incorrect date format");
                }
            } while (!isCorrect);


            isCorrect = false;

            do
            {
                Console.WriteLine("Enter salary:");
                if (decimal.TryParse(Console.ReadLine(), out salary))
                    isCorrect = true;
                else
                {
                    Console.WriteLine("Incorrect salary format");
                }
            } while (!isCorrect);

            return new Employee 
                
            {
                Name = name,
                Birthdate = birthdate,
                Salary = salary
            };
            
 
            // return e;
        }

        
        
        
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            Employee e = null;
            
           

            do
            {
                e = InputEmployee();
                if (e.Name != null)
                employees.Add(e);
            } while (e.Name != null);
            
            OutputEmployees(employees);
            var young = YoungEmployees(employees);
            Console.ReadKey();

            /*Employee e = new Employee()
            {
                Name = "John",
                Birthdate = new DateTime(1980, 4, 5),
                Salary = 67000
            };
            
            employees.Add(e);

            employees.Add(new Employee
            {
                Name = "Andrew",
                Birthdate = new DateTime(1985, 7, 8),
                Salary = 50000
            });
            */


        }
    }
}