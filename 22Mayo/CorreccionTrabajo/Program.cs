using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            var response = from student in Database.Students
                           join study in Database.Studies on student.Id equals study.IdStudent
                           join subject in Database.Subjects on study.IdSubject equals subject.Id
                           where study.Semester == "5" && study.Grade == "A"
                           select new { student.Name, student.Lastname };

            foreach (var result in response)
            {
                Console.WriteLine($"Nombre: {result.Name}, Apellido: {result.Lastname}");
            }
        }

        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Lastname { get; set; }

            public Student(int id, string name, string lastname)
            {
                Id = id;
                Name = name;
                Lastname = lastname;
            }
        }

        public class Subject
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public Subject(int id, string name)
            {
                Id = id;
                Name = name;
            }
        }

        public class Study
        {
            public int IdStudent { get; set; }
            public int IdSubject { get; set; }
            public string Grade { get; set; }
            public string Semester { get; set; }

            public Study(int idStudent, int idSubject, string grade, string semester)
            {
                IdStudent = idStudent;
                IdSubject = idSubject;
                Grade = grade;
                Semester = semester;
            }
        }

        public static class Database
        {
            public static List<Student> Students = new List<Student>
            {
                new Student(1, "Juan", "Perez"),
                new Student(2, "Vargas", "Vargas"),
                new Student(3, "Carlos", "Lopez"),
                new Student(4, "Jheremy", "Doku"),
                new Student(5, "Carlos", "Bros")
            };

            public static List<Subject> Subjects = new List<Subject>
            {
                new Subject(1, "DesarolloSoftwareV"),
                new Subject(2, "Sistemas"),
                new Subject(3, "Electronica")
            };

            public static List<Study> Studies = new List<Study>
            {
                new Study(1, 1, "A", "5"),
                new Study(2, 2, "B", "4"),
                new Study(3, 1, "A", "5"),
                new Study(4, 3, "B", "4"),
                new Study(5, 2, "A", "5")
            };
        }
    }
}
