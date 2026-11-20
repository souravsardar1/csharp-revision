
using System;

namespace OOP
{
    interface IPayment
    {
        void Pay();
    }
    class Car
    {
        public string Brand = "Toyota";
        public string Color = "Red";
    } // Close Car class here

    class Person
    {
        public  string Name { get; set; }
        public int Age { get; set; }

        // Property with default value
        public int Year { get; set; } = 2020;
    }


    class BankAccount

    {
        public double Balance { get; private set; }

        public BankAccount(double initialBalance)
        {
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }
    }

    class Animal
    {

        public string Name { get; set; }
        public void eat()
        {
            Console.WriteLine($"{Name} is eating...");
        }
    }

    class Dog : Animal
    {
        public void bark()
        {
            Console.WriteLine($"{Name} is barking...");
        }
    }


    //polymorphism
    class Mamals
    {
        public virtual void sound()
        {
            Console.WriteLine("Mammal makes a sound");
        }
    }

    class Cat : Mamals
    {
        public override void sound()
        {
            Console.WriteLine("Cat meows");
        }
    }

    class Bear : Mamals
    {
        public override void sound()
        {
            Console.WriteLine("Bear growls");
        }
    }

    class UpIPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Payment made using UPI");
        }
    }

    class CreditCardPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Payment made using Credit Card");
        }
    }

    //composition -object inside object
    class Engine
    {
        public void Start()
        {
            Console.WriteLine("Engine Started");
        }
    }

    class Van
    {
        public Engine MyEngine {get; set;}

        public Van()
        {
            MyEngine = new Engine();
        }

        public void StartCar()
        {
            MyEngine.Start();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Console.WriteLine(myCar.Brand);
            Console.WriteLine(myCar.Color);

            Car car2 = new Car();
            car2.Brand = "Honda";
            car2.Color = "Blue";

            Console.WriteLine(car2.Brand);
            Console.WriteLine(car2.Color);

            Car car3 = new Car();
            car3.Brand = "Ford";
            car3.Color = "Black";

            Console.WriteLine(car3.Brand);
            Console.WriteLine(car3.Color);

            // Using properties (modern way)
            Person person1 = new Person();
            person1.Name = "John";
            person1.Age = 30;

            Console.WriteLine(person1.Name);
            Console.WriteLine(person1.Age);
            Console.WriteLine(person1.Year);





            // Using BankAccount class
            BankAccount account = new BankAccount(1000);
            Console.WriteLine($"Initial Balance: {account.Balance}");

            account.Deposit(500);
            Console.WriteLine($"Balance after deposit: {account.Balance}");

            // account.Balance = 500; // This line will cause a compilation error because Balance has a private setter





            // using inheritance
            Dog dog = new Dog();
            dog.Name = "Buddy";
            dog.eat(); // Inherited method
            dog.bark(); // Dog's own method
           


            // Using polymorphism
            Mamals myCat = new Cat();
            myCat.sound(); // Calls the overridden method in Cat class 

            Mamals myBear = new Bear();
            myBear.sound(); // Calls the overridden method in Bear class 


            // Using interface
            IPayment payment1 = new UpIPayment();
            payment1.Pay();

            IPayment payment2 = new CreditCardPayment();
            payment2.Pay();

            //composition object
            Van van = new Van();
            van.StartCar();
            
        }
    }
}



//example of composition

/*


1. Without composition
Suppose you have a Car class:
class Car
{
    public string Brand = "Toyota";
    public string Color = "Red";
}


And you have an Engine class:
class Engine
{
    public int HorsePower = 150;
    public string Type = "Petrol";
}


Both classes are independent. The Car doesn't know anything about the Engine.
2. With composition
Now let's connect these two classes.



using System;

namespace OOP
{
    class Engine
    {
        public int HorsePower = 150;
        public string Type = "Petrol";

        public void Start()
        {
            Console.WriteLine("Engine started!");
        }
    }

    class Car
    {
        public string Brand = "Toyota";
        public string Color = "Red";

        // Composition: Car HAS-A Engine
        public Engine MyEngine = new Engine();

        public void StartCar()
        {
            MyEngine.Start();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            Console.WriteLine(myCar.Brand);
            Console.WriteLine(myCar.Color);

            Console.WriteLine(myCar.MyEngine.Type);
            Console.WriteLine(myCar.MyEngine.HorsePower);

            myCar.StartCar();
        }
    }
}

*/