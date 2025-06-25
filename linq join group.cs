using System;
using System.Collections.Generic;
using System.Linq;

namespace OkulVeritabani
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int ClassId { get; set; }
    }

    public class Class
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { StudentId = 1, StudentName = "Ali", ClassId = 101 },
                new Student { StudentId = 2, StudentName = "Ayşe", ClassId = 102 },
                new Student { StudentId = 3, StudentName = "Mehmet", ClassId = 101 },
                new Student { StudentId = 4, StudentName = "Zeynep", ClassId = 103 },
                new Student { StudentId = 5, StudentName = "Hasan", ClassId = 102 }
            };

            List<Class> classes = new List<Class>
            {
                new Class { ClassId = 101, ClassName = "Matematik" },
                new Class { ClassId = 102, ClassName = "Fizik" },
                new Class { ClassId = 103, ClassName = "Kimya" }
            };

            var classGroups = from cls in classes
                              join stu in students on cls.ClassId equals stu.ClassId into studentGroup
                              select new
                              {
                                  ClassName = cls.ClassName,
                                  Students = studentGroup
                              };

            foreach (var group in classGroups)
            {
                Console.WriteLine($"Sınıf: {group.ClassName}");
                foreach (var student in group.Students)
                {
                    Console.WriteLine($" - {student.StudentName}");
                }
                Console.WriteLine();
            }
        }
    }
}
