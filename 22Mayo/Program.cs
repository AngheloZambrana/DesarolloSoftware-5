using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            var response = Database.Students.Where(student => student.materia == "DesarolloSoftwareV");
                        
            foreach (var student in response)
            {
                Console.WriteLine($"Nombre: {student.name}, Apellido: {student.lastname}");
            }
        }

        public class Student
        {
            public int id { get; set; }
            public string name { get; set; }
            public string lastname { get; set; }
            public string materia {get; set;}

            public Student(int id, string name, string lastname, string materia)
            {
                this.id = id;
                this.name = name;
                this.lastname = lastname;
                this.materia = materia;
            }
        }

        public static class Database
        {
            public static List<Student> Students = new List<Student>
            {
                new Student(1, "Juan", "Perez", "DesarolloSoftwareV"),
                new Student(2, "Vargas", "Vargas", "Sistemas"),
                new Student(3, "Carlos", "Lopez", "DesarolloSoftwareV"),
                new Student(4, "Jheremy", "Doku", "Electroinca"),
                new Student(5, "Carlos", "Bros", "DesarolloSoftwareV")
            };
        }
    }
}
