using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionAndAttribute
{
    public class Car
    {
        [Names(Values = "CarId")]
        public int Id { get; set; }
        [Names(Values = "CarName")]
        public string Name { get; set; }
        public string Manufacturer { get; set; }
    }
}
