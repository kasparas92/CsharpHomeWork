using System;
using System.Collections.Generic;
using System.Text;

namespace SortedListDictionaryAndHashSet
{
    public class SortedListExample
    {
        public void BuildExample()
        {
            var numbers = new SortedList<int, string>()
            {
                { 4, "Four" },
                { 1, "One" },
                { 3, "Three" },
                { 7, "Seven" },
                { 5, "Five" },
                { 6, "Six" },
                { 2, "Two" },
            };

            numbers.Add(8, "Eight");

            if(!numbers.ContainsKey(9))
            {
                numbers.Add(9, "Nine");
            }

            if(numbers.ContainsValue("Eight"))
            {
                var i = numbers.IndexOfKey(8);
                numbers.RemoveAt(i);
            }

            var newList = numbers;

            foreach(var list in numbers)
            {
                Console.WriteLine($"Number {list.Key} in letters are {list.Value}");
            }
            Console.WriteLine($"Capacity of this Sorted list is {numbers.Capacity}");
            Console.WriteLine($"Count of this Sorted list is {numbers.Count}");
            Console.WriteLine($"Number 7 index in the list is {numbers.IndexOfValue("Seven")}");
            if (numbers.Equals(newList))
            {
                Console.WriteLine("numbers and newList are 2 equal list");
            }
            else
            {
                Console.WriteLine("2 lists are not equal");
            }
        }
    }
}
