using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionAndAttribute
{
    public class Student
    {
        [Names(Values = "StudentId")]
        public int Id { get; set; }
        [Names(Values = "StudentName")]
        public string Name { get; set; }
        public string Address { get; set; }
        public string MobileNo { get; set; }
    }
}
