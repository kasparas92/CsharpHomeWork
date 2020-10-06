using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var cust1 = new List<Customer>
            {
                new Customer
                {
                    Id = 1,
                    Name = "Peter"
                },
                new Customer
                {
                    Id = 2,
                    Name = "John"
                },
                new Customer
                {
                    Id = 3,
                    Name = "Anthony"
                },
                new Customer
                {
                    Id = 4,
                    Name = "Michael"
                },
                new Customer
                {
                    Id = 5,
                    Name = "Jeremy"
                },
                new Customer
                {
                    Id = 6,
                    Name = "Nikhil"
                }
            };

            var cust2 = new List<Customer>
            {
                new Customer
                {
                    Id = 2,
                    Name = "Jonas"
                },
                new Customer
                {
                    Id = 4,
                    Name = "Petras"
                },
                new Customer
                {
                    Id = 6,
                    Name = "Antanas"
                },
                new Customer
                {
                    Id = 8,
                    Name = "Lukas"
                },
                new Customer
                {
                    Id = 10,
                    Name = "Martynas"
                },
                new Customer
                {
                    Id = 12,
                    Name = "Aloyzas"
                }
            };

            var query = (from c1 in cust1
                         where c1.Name.StartsWith('A') && !(
                                                            from c2 in cust2
                                                            where c2.Name.StartsWith('A')
                                                            orderby c2.Name
                                                            select c2.Id)
                                                            .Take(20)
                                                            .Contains(c1.Id)
                         orderby c1.Name
                         select c1.Id)
                         .Take(10).ToList();

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}