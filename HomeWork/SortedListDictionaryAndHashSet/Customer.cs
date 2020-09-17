using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SortedListDictionaryAndHashSet
{
    public class Customer: IEquatable<Customer>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public bool Equals(Customer other)
        {
            return (Name.Equals(other.Name) && other.Age == Age);
        }

        public override int GetHashCode()
        {
            var hashCode = 13;
            hashCode = (hashCode * 15) ^ Age;
            var myStrHashCode = !string.IsNullOrEmpty(Name) ? Name.GetHashCode() : 0;
            hashCode = (hashCode * 15) ^ myStrHashCode;
            return hashCode;
        }
    }
}
