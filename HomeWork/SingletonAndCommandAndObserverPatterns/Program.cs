using System;

namespace SingletonAndCommandAndObserverPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Signleton Example: ");

            Calculate.Instance.ValueNr1 = 10.5;
            Calculate.Instance.ValueNr2 = 5.5;
            Console.WriteLine("Addition : " + Calculate.Instance.Addition());
            Console.WriteLine("Subtraction : " + Calculate.Instance.Subtraction());
            Console.WriteLine("Multiplication : " + Calculate.Instance.Multiplication());
            Console.WriteLine("Division : " + Calculate.Instance.Division());
            Console.WriteLine("\n----------------------\n");
            Calculate.Instance.ValueNr2 = 10.5;
            Console.WriteLine("Addition : " + Calculate.Instance.Addition());
            Console.WriteLine("Subtraction : " + Calculate.Instance.Subtraction());
            Console.WriteLine("Multiplication : " + Calculate.Instance.Multiplication());
            Console.WriteLine("Division : " + Calculate.Instance.Division());

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Command Pattern");

            var modifySpeed = new ModifySpeed();
            var car = new Car("BMW", 150);

            var increase = new CarCommand(car, SpeedAction.Increase, 65);
            var decrease = new CarCommand(car, SpeedAction.Decrease, 20);


            modifySpeed.SetCommand(increase);
            modifySpeed.Invoke();
            Console.WriteLine(car.ToString());

            modifySpeed.SetCommand(decrease);
            modifySpeed.Invoke();
            Console.WriteLine(car.ToString());

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Observer Pattern");

            var subject = new Subject();
            var observerA = new ConcreteObserverA();
            subject.Attach(observerA);

            var observerB = new ConcreteObserverB();
            subject.Attach(observerB);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

            subject.Detach(observerB);

            subject.SomeBusinessLogic();

            Console.WriteLine("Finished!!!");

            Console.ReadLine();
        }
    }
}
