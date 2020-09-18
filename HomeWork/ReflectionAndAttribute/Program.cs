using System;
using System.Collections.Generic;
using System.Data;

namespace ReflectionAndAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            var dt = new DataTable("Student");
            dt.Columns.Add("StudentId", typeof(Int32)); //Id for student
            dt.Columns.Add("StudentName", typeof(string));
            dt.Columns.Add("Address", typeof(string));
            dt.Columns.Add("MobileNo", typeof(string));

            dt.Rows.Add(1, "Peter", "London", "0000000000");
            dt.Rows.Add(2, "John", "Cambridge", "111111111");
            dt.Rows.Add(3, "Dom", "Liverpool", "1222222222");
            dt.Rows.Add(4, "Brian", "Manchester", "3333333333");

            var studentDetails = Converter.ConvertDataTable<Student>(dt);

            foreach(var student in studentDetails)
            {
                Console.WriteLine($"ID: {student.Id}");
                Console.WriteLine($"Name: {student.Name}");
                Console.WriteLine($"Address: {student.Address}");
                Console.WriteLine($"MobileNo: {student.MobileNo}");
            }

            var carDt = new DataTable("Car");
            carDt.Columns.Add("CarId", typeof(Int32));
            carDt.Columns.Add("CarName", typeof(string));
            carDt.Columns.Add("Manufacturer", typeof(string));

            carDt.Rows.Add(1, "318", "BMW");
            carDt.Rows.Add(2, "M550i", "BMW");
            carDt.Rows.Add(3, "M5 Competition", "BMW");
            carDt.Rows.Add(4, "750Li", "BMW");

            var cars = Converter.ConvertDataTable<Car>(carDt);

            foreach (var c in cars)
            {
                Console.WriteLine($"ID: {c.Id}");
                Console.WriteLine($"Name: {c.Name}");
                Console.WriteLine($"Manufacturer: {c.Manufacturer}");
            }

            Console.ReadLine();
        }
    }
}
