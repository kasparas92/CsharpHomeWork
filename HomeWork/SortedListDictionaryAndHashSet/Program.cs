using System;
using System.Collections.Generic;

namespace SortedListDictionaryAndHashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("SortedDictionary example");
            //var sd = new SortedDictionaryExample();
            //sd.BuildExample();
            //Console.WriteLine("-------------------------");
            //Console.WriteLine("SortedList example");
            //var sl = new SortedListExample();
            //sl.BuildExample();
            //Console.WriteLine("-------------------------");
            //Console.WriteLine("Hashset example");
            var customers = new HashSet<Customer>();

            var customer1 = new Customer() { Name = "John", Age = 25 };
            var customer2 = new Customer() { Name = "Peter", Age = 38 };

            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(new Customer { Name = "John", Age = 25 });

            foreach (var c in customers)
            {
                Console.WriteLine($"Name: {c.Name}, Age: {c.Age}");
            }

            Console.ReadLine();
        }
    }
}
