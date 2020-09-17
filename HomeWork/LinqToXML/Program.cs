using LinqExamples;
using System;
using System.Linq;
using System.Xml.Linq;

namespace LinqToXML
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = Student.GetStudents();

            var element1 = new XElement("Stundets", 
                (from std in students
                 select new XElement("Student",
                 new XElement("Id", std.ID),
                 new XElement("Name", std.Name),
                 new XElement("TotalMarks", std.TotalMarks),
                 new XElement("Subjects",
                    (from subj in std.Subjects
                    select new XElement("Subject", 
                        new XElement("SubjectName", subj.SubjectName),
                        new XElement("Marks", subj.Marks)))
                 ))));

            var element2 = new XElement("Students",
                                        students.Select(i =>
                                        new XElement("Student",
                                            new XElement("Id", i.ID),
                                            new XElement("Name", i.Name),
                                            new XElement("TotalMarks", i.TotalMarks),
                                            new XElement("Subjects", i.Subjects.Select(s =>
                                                                     new XElement("Subject",
                                                                     new XElement("SubjectName", s.SubjectName),
                                                                     new XElement("Marks", s.Marks))))
                                            )));

            Console.WriteLine("LINQ to XML LINQ Query Syntax");
            Console.WriteLine(element1);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("LINQ to XML LINQ Method Syntax: ");
            Console.WriteLine(element2);

            Console.ReadLine();
        }
    }
}