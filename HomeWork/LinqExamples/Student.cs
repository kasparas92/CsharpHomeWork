using System;
using System.Collections.Generic;
using System.Text;

namespace LinqExamples
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int TotalMarks { get; set; }
        public List<Subject> Subjects { get; set; }
        public static List<Student> GetStudents()
        {
            List<Student> stud1 = new List<Student>();
            stud1.Add(new Student
            {
                ID = 101,
                Name = "Preety",
                TotalMarks = 255,
                Subjects = new List<Subject>()
                    {
                        new Subject(){SubjectName = "Math", Marks = 80},
                        new Subject(){SubjectName = "Science", Marks = 90},
                        new Subject(){SubjectName = "English", Marks = 95}
                    }
            });
            stud1.Add(new Student
            {
                ID = 102,
                Name = "Sambit",
                TotalMarks = 275,
                Subjects = new List<Subject>()
                    {
                        new Subject(){SubjectName = "Math", Marks = 90},
                        new Subject(){SubjectName = "Science", Marks = 95},
                        new Subject(){SubjectName = "English", Marks = 93}
                }
            });


            stud1.Add(new Student
            {
                ID = 103,
                Name = "Hina",
                TotalMarks = 240,
                Subjects = new List<Subject>()
                    {
                        new Subject(){SubjectName = "Math", Marks = 70},
                        new Subject(){SubjectName = "Science", Marks = 80},
                        new Subject(){SubjectName = "English", Marks = 90}
                    }
            });
            stud1.Add(new Student
            {
                ID = 104,
                Name = "Anurag",
                TotalMarks = 278,
                Subjects = new List<Subject>()
                    {
                        new Subject(){SubjectName = "Math", Marks = 90},
                        new Subject(){SubjectName = "Science", Marks = 90},
                        new Subject(){SubjectName = "English", Marks = 95}
                    }
            });
            stud1.Add(new Student
            {
                ID = 105,
                Name = "Pranaya",
                TotalMarks = 265,
                Subjects = new List<Subject>()
                    {
                        new Subject(){SubjectName = "Math", Marks = 80},
                        new Subject(){SubjectName = "Science", Marks = 90},
                        new Subject(){SubjectName = "English", Marks = 85}
                    }
            });
            stud1.Add(new Student
            {
                ID = 106,
                Name = "Santosh",
                TotalMarks = 263,
                Subjects = new List<Subject>()
                    {
                        new Subject(){SubjectName = "Math", Marks = 86},
                        new Subject(){SubjectName = "Science", Marks = 70},
                        new Subject(){SubjectName = "English", Marks = 95}
                    }
            });

            return stud1;
        }

        public static List<Student> GetMeritStudent()
        {
            List<Student> stud = new List<Student>();
            stud.Add(new Student { ID = 102, Name = "Sambit" });
            stud.Add(new Student { ID = 104, Name = "Anurag" });
            stud.Add(new Student { ID = 105, Name = "Pranaya" });
            return stud;
        }


    }
}
