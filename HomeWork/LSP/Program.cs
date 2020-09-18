using System;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter lenght of int array you want to sum: ");
            var a = Convert.ToInt32(Console.ReadLine());
            var numberss = new int[a];
            for (var i = 0; i < a;i++)
            {
                Console.WriteLine("Enter int number: ");
                numberss[i] = Convert.ToInt32(Console.ReadLine());
            }

            Calculator even = new EvenNumberSumCalculator(numberss);
            Calculator odd = new OddNumberSumCalculator(numberss);
            Calculator normal = new NumbersSumCalculator(numberss);


            Console.WriteLine($"All Numbers sum = {normal.CalculateSum()}");
            Console.WriteLine($"Odd Numbers sum = {odd.CalculateSum()}");
            Console.WriteLine($"Even Numbers sum = {even.CalculateSum()}");

            Console.ReadLine();
        }
    }
}
