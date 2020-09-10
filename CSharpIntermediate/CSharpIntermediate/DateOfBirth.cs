using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediate
{
    public class DateOfBirth
    {
        public int day;
        public int month;
        public int year;
        public DateOfBirth()
        {
                
        }
        public void AssignValue(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public bool DataValidation()
        {
            if (day > 31 || month > 12 || year < 1962)
            {
                Console.WriteLine("Please enter Valid date");
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool DisplayDate()
        {
            if(DataValidation())
            {
                Console.WriteLine($"{day} {month} {year}");
                return true;
            }
            else
            {
                Console.WriteLine("Please enter date again");
                return false;
            }
        }
    }
}
