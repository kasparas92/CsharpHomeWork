using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = Student.GetStudents();
            var meritStudents = Student.GetMeritStudent();

            Console.WriteLine("1.  Fetch StudentName who are not part of Merit List. ");
            var studentsWhoAreNotPartOfMerit = students.GroupJoin(meritStudents, std => std.ID, mrt => mrt.ID, (x, y) => new { students = x, meritStudents = y })
                                .SelectMany(x => x.meritStudents.DefaultIfEmpty(),
                                            (x, y) => new { x.students, MeritStudentName = y?.Name ?? String.Empty})
                                .Where(x => x.MeritStudentName == String.Empty)
                                .Select(x => x.students.Name);

            foreach(var v in studentsWhoAreNotPartOfMerit)
            {
                Console.WriteLine($"Student Name: {v}");
            }

            Console.WriteLine("2.  Fetch StudentDetails which are part of Student1 Object and Not Student Object. ");

            Console.WriteLine("3.  Fetch Record of Students Whose Total marks > 265. ");

            var studentRecords = students.Where(x => x.TotalMarks > 265);

            foreach (var v in studentRecords)
            {
                Console.WriteLine($"ID: {v.ID}, {v.Name}, {v.TotalMarks}:");
                foreach (var s in v.Subjects)
                {
                    Console.Write($"SubjectName: {s.SubjectName}, Mark: {s.Marks}");
                    Console.WriteLine();
                }
            }

            Console.WriteLine("4.  Fetch Student Record whose marks in each Subject > 80. ");

            var marksBiggerThan80 = students.Select(x => new { x.ID, x.Name, x.Subjects, x.TotalMarks, IfAllMarksBiggerThan80 = x.Subjects.All(m => m.Marks > 80) })
                                            .Where(x => x.IfAllMarksBiggerThan80);

            foreach (var v in marksBiggerThan80)
            {
                Console.WriteLine($"ID: {v.ID}, {v.Name}, {v.TotalMarks}:");
                foreach (var s in v.Subjects)
                {
                    Console.Write($"SubjectName: {s.SubjectName}, Mark: {s.Marks}");
                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }
    }
}
