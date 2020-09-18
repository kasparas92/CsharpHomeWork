using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionAndAttribute
{
    public class NamesAttribute : Attribute
    {
        public string Values { get; set; }
    }
}
