using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortedListDictionaryAndHashSet
{
    public class SortedDictionaryExample
    {
        public void BuildExample()
        {
            var names = new SortedDictionary<string, List<string>>()
            {
                { "A", new List<string>() { "Ammy", "Abby", "Arthur", "Alex" } },
                { "C", new List<string>() { "Charles" } },
                { "B", new List<string>() { "Brooke", "Bobby" } },

            };

            if (!names.ContainsKey("Z"))
            {
                names.Add("Z", new List<string>() { "Zander", "Zane" });
            }

            foreach (var list in names)
            {
                foreach(var i in list.Value)
                {
                    Console.WriteLine($"Names of letter {list.Key} are {i}");
                }
            }

            Console.WriteLine("---------------------------------------------------------");

            var newNames = new SortedDictionary<string, string>()
            {
                { "A", "Amy" },
                { "C", "Charles" },
                { "Z", "Zane" }
            };

            var newNames2 = new SortedDictionary<string, string>()
            {
                { "A", "Amy" },
                { "C", "Charles" }
            };

            if (newNames.ContainsValue("Zane"))
            {
                newNames.Remove("Z");
            }

            if( newNames2.Equals(newNames))
            {
                Console.WriteLine("2 SortedDictionaries are equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }

            if(newNames2.ContainsValue("Amy"))
            {
                newNames2.Clear();
            }

            IDictionaryEnumerator enumerator = newNames.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine($"Names of letter {enumerator.Key} are {enumerator.Value}");
            }
        }
    }
}
