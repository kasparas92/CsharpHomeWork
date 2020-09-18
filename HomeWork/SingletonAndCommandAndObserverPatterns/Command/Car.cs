using System;

namespace SingletonAndCommandAndObserverPatterns
{
    public class Car
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        public Car(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }

        public void IncreaseSpeed(int amount)
        {
            Speed += amount;
            Console.WriteLine($"{Brand}'s speed was increased by {amount}km/h");
        }
        public void DecreaseSpeed(int amount)
        {
            if(amount < Speed)
            {
                Speed -= amount;
                Console.WriteLine($"{Brand}'s speed was decreased by {amount}km/h");
            }
        }

        public override string ToString() => $"Current {Brand}'s speed is {Speed}km/h";
    }
}
