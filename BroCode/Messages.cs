using System;
using System.Collections.Generic;
using System.Text;

namespace BroCode
{
    /*double x = 12.5;
            Console.WriteLine(x);
            Console.WriteLine(x / 10);
            Console.WriteLine(x % 10);

            Console.WriteLine(x + " divided by " + 10 + " is equal to " + x / 10);
            Console.WriteLine(x + " modulus " + 10 + " is equal to " + x % 10);

            bool alive = true;

            if (alive) Console.WriteLine("You are alive" + alive);
            else Console.WriteLine("You are not alive" + alive);

            Console.Write("Enter your name: ");
            String name = Console.ReadLine();*/

    /* const double pi = 3.14159; 

    Console.WriteLine(pi); */

    /* Type casting
     * double a = 3.1416;
    Console.WriteLine(a.GetType());

    int b = 1234;

    double doubleB = Convert.ToDouble(b);
    Console.WriteLine(doubleB); */


    //User input
    /* Console.Write("Please enter your name: "); String userName = Console.ReadLine();
    Console.WriteLine("Hello " + userName + ", nice to meet you!");

    Console.Write("Can I have your age: "); int userAge = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Your age: " + userAge); */



    /* Some interesting stuff
     * Console.Write("Please enter number between 1 and 10: ");
    int chances = Convert.ToInt32(Console.ReadLine());
    int i = 0;
    while (chances >= 0)
    {
        Console.Write("Enter " + (i + 1) + " friend name: ");
        String friendName = Console.ReadLine();
        Console.WriteLine((i + 1) + " friend's name: " + friendName);
        chances--;
        i++;    
    }

    Console.Write("This program will show whether " +
                  "number is odd or even until your input number. Enter number: ");
    int anyNumber = Convert.ToInt32((Console.ReadLine()));
    for (int f = 0; f <= anyNumber; f++)
    {
        if (f % 2 == 0)
            Console.WriteLine(f + " is even");
        else
            Console.WriteLine(f + " is odd");
    }
    */

    // Math stuff
    /* double x = 3;

    Console.WriteLine(Math.Pow(x, 3));
    Console.WriteLine(Math.Sqrt(x));
    Console.WriteLine(Math.Sqrt(Math.PI));
    Console.WriteLine(Math.Sqrt(Math.E));
    Console.WriteLine("Abs " + x + ": " + Math.Abs(x));
    Console.WriteLine("Round " + x + ": " + Math.Round(x));
    Console.WriteLine("Math.Round");
    Console.WriteLine(Math.Round(3.4));
    Console.WriteLine(Math.Round(3.5));
    Console.WriteLine(Math.Round(3.6));
    Console.WriteLine("Math.Ceiling");
    Console.WriteLine(Math.Ceiling(3.4));
    Console.WriteLine(Math.Ceiling(3.5));
    Console.WriteLine(Math.Ceiling(3.6));
    Console.WriteLine("Math.Floor");
    Console.WriteLine(Math.Floor(3.4));
    Console.WriteLine(Math.Floor(3.5));
    Console.WriteLine(Math.Floor(3.6)); */

    // Generating random number 
    /* 
    Random random = new Random();

    int firstR = random.Next();
    Console.WriteLine("Random integer: " + firstR);

    double randomD = random.NextDouble() + 45.8;
    Console.WriteLine("Random double: " + randomD);

    double randomS = random.NextDouble() + 1.2;
    Console.WriteLine("Original random double: " + randomS); */

    // Some problem solution with c#
    /* 
    Console.Write("A: ");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.Write("B: ");
    double b = Convert.ToDouble(Console.ReadLine());

    double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
    Console.WriteLine("C: " + c);
    */

    /* String fullName = "Murtazo Toshniyozov";

    String fullName1 = fullName.ToUpper();
    Console.WriteLine("Upper case: " + fullName1);

    String fullName2 = fullName.ToLower();
    Console.WriteLine("Lower case: " + fullName2);

    String userName = fullName.Insert(0, "@");
    Console.WriteLine("Demo: " + userName);

    String phoneNumber = "010-9500-1888";

    String phoneNumber1 = phoneNumber.Replace("-", "");
    Console.WriteLine("Without '-': " + phoneNumber1);

    String firstName = fullName.Substring(0, 7);
    Console.WriteLine("First Name: " + firstName);

    String lastName = fullName.Substring(8);
    Console.WriteLine("Last Name: " + lastName);*/

    // switches
    /* Console.Write("Enter day of the week: ");
    String day = Console.ReadLine(); 
    day = day.ToLower();

    switch(day)
    {
        case "monday": Console.WriteLine("It is " + day); break;
        case "tuesday": Console.WriteLine("It is " + day); break;
        case "wednesday": Console.WriteLine("It is " + day); break;
        case "thursday": Console.WriteLine("It is " + day); break;
        case "friday": Console.WriteLine("It is " + day); break;
        case "saturday": Console.WriteLine("It is " + day); break;
        case "sunday": Console.WriteLine("It is " + day); break;
        default: Console.WriteLine("Wrond week day input!"); break;
    }
    */

    // Logical order
    /* 
    Console.Write("What is the temperature outside? ");
    double t = Convert.ToDouble(Console.ReadLine());
    if (t >= 10 && t <= 25)
    {
        Console.WriteLine("It is warm outside");
    }
    else if (t <= -50 && t >= 50)
    {
        Console.WriteLine("Do not even think even going outside!");
    }
    else Console.WriteLine("Do whatever you want =)");
    */

    /* for (int i = 1; ; i++)
    {
        if (i == 8)
        {
            Console.WriteLine("It is " + i + " and I have to stop here");
            break;
        }
        else
        {
            Console.WriteLine(i);
        }
    } */

    /* int row = Convert.ToInt32(Console.ReadLine());
     int column = Convert.ToInt32(Console.ReadLine());
     char symbol = Convert.ToChar(Console.ReadLine());
     while(row > -1)
     {
         for (int i = 1; i <= column; i++ )
         {
             Console.Write(symbol + " ");
         }
         Console.WriteLine("\n");
         row--;
     }
    */



    /* 
    while(playAgain)
    {
        guess = random.Next(1, 100);
        number = 0;
        response = "";
        while(number != guess)
        {
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number > guess) Console.WriteLine(number + " is too high");
            else if (number < guess) Console.WriteLine(number + " is too low");


            guesses++;
        }

        Console.WriteLine("Congratulation. YOU WON!");
        Console.Write("Would you like to play again? (Y/N)");
        response = Console.ReadLine();
        response = response.ToUpper();
        if (response == "Y")
        {
            playAgain = true;
        }
        else
        {
            Console.WriteLine("Thank you for playing");
            playAgain = false;
        }
    } */
    /*
    Console.WriteLine("Welcome to Rock, Paper, Scissors game!");
    Console.WriteLine("You have 3 chances to win computer =)");
    Random random = new Random();
    bool playAgain = true;
    //int guess, number, guesses = 0;
    String response = "";
    String player = "";
    String computer = "";
    //int countPlayer = 0, countComputer = 0, chances = 3;

    while (playAgain)
    {
        player = "";
        computer = "";
        response = "";
        while (player != "rock" && player != "paper" && player != "scissors")
        {
            // player choice
            Console.Write("Enter Rock, Paper or Scissors: ");
            player = Console.ReadLine();
            player = player.ToLower();
        }


        switch (random.Next(0, 3))
        {
            case 0: computer = "rock"; break;
            case 1: computer = "paper"; break;
            case 2: computer = "scissors"; break;
        }

        Console.WriteLine("Player: " + player);
        Console.WriteLine("Computer: " + computer);

        switch (player)
        {
            case "rock":
                if (computer == "rock")
                {
                    Console.WriteLine("Draw");
                }
                else if (computer == "paper")
                {
                    Console.WriteLine("Computers wins!");
                }
                else if (computer == "scissors")
                {
                    Console.WriteLine("You win!");
                }
                break;
            case "paper":
                if (computer == "rock")
                {
                    Console.WriteLine("You win!");
                }
                else if (computer == "paper")
                {
                    Console.WriteLine("Draw");
                }
                else if (computer == "scissors")
                {
                    Console.WriteLine("Computers wins!");
                }
                break;
            case "scissors":
                if (computer == "rock")
                {
                    Console.WriteLine("Computers wins!");
                }
                else if (computer == "paper")
                {
                    Console.WriteLine("You win!");
                }
                else if (computer == "scissors")
                {
                    Console.WriteLine("Draw");
                }
                break;   
        }

        Console.WriteLine("Would you like to play again? (Y/N)");
        Console.Write("Your answer: "); response = Console.ReadLine();
        response = response.ToUpper();
        if (response == "Y") playAgain = true;
        else
        {

            playAgain = false;
        }
    }
    Console.WriteLine("Thank you for playing");*/

    // array
    /*String[] cars = { "BMM", "Mustang", "WolksWagen", "Bugatti" };
    String temp = "";
    //Console.WriteLine(cars[0][0]);
    for (int i = 0; i < cars.Length; i++)
    {
           if (cars[i] == "BMV")
           {
            cars[i] = "MvB";
           }
    }

    foreach (String car in cars)
    {
        Console.WriteLine(car);
    }
    */

    //singHappyBirthday();

    //singHappyBirthday();

    /* double[] ints = { 1, 23.5, 56.90 };

    Console.WriteLine(addPrice(ints)); */
    // handling exceptions
    /*
    double x;
    double y;
    double result;

    try
    {


        Console.Write("x: "); x = Convert.ToDouble(Console.ReadLine());
        Console.Write("y: "); y = Convert.ToDouble(Console.ReadLine());
        result = x / y;

        Console.WriteLine("Result: " + result);
    }
    catch (FormatException format_exception)
    {
        Console.WriteLine("Enter numbers only!");
    }
    catch (DivideByZeroException divide_by_zero_exception)
    {
        Console.WriteLine("You can not divide by 0");
    }
    catch (Exception e) { Console.WriteLine("Something went wrong"); } */

    /* 2d arrays
    String[,] parkingLot =
    {
        {"BMV", "Toyota", "Chevrolet" },
        {"Corvetter", "Camaro", "Silverado" },
        {"Corolla", "Camry", "Mercedes" }
    };

    for (int i = 0; i < parkingLot.GetLength(0); i++)
    {
        Console.Write("Row " + (i + 1) + ": ");
        for (int j = 0; j < parkingLot.GetLength(1); j++)
        {
            Console.Write(parkingLot[i, j] + " ");
        }
        Console.WriteLine();
    } */

    /* Messages.Hello();
    Messages.Waiting();
    Messages.Bye(); */

    /* creating array of objects
     * Car[] garage = { new Car("Mustang"), new Car("Bugatti"), new Car("Mercedes") };


            foreach (Car car in garage)
            {
                Console.WriteLine(car.model);
            }*/

    /* Car car1 = new Car("Mustang", "red");
            ChangeColor(car1, "silver");
            Console.WriteLine("Model: " + car1.model + "\n" + "Color: " + car1.color);
            */
    /* Dog dog = new Dog();
    dog.Speak();
    Cat cat = new Cat();
    cat.Speak(); */

    /* Car car = new Car();    
    Bicycle bicycle = new Bicycle();
    Boat boat = new Boat();

    Vehicle[] vehicle = { car, bicycle, boat};

    foreach(Vehicle v in vehicle)
    {
        v.Go();
    }
    */
    //Console.WriteLine();

    /*Rabbit rabbit = new Rabbit();   
    Hawk hawk = new Hawk();
    Fish fish = new Fish();

    rabbit.Flee();
    hawk.Hunt();
    fish.Flee();
    fish.Hunt(); */

    //Console.ReadLine();
    //Console.Beep();
}

/* static void singHappyBirthday()
{
    Console.WriteLine("Happy birthday to you");
    Console.WriteLine("Happy birthday to you");
    Console.WriteLine("Happy birthday to you");
    Console.WriteLine();
}

static double addPrice(double[] arrayPrices)
{
    double total = 0;

    foreach (double price in arrayPrices)
    {
        total += price;
    }
    return total;
} */
static class Messages
    {
        public static void Hello()
        {
            Console.WriteLine("Hey there!");
        }

        public static void Waiting()
        {
            Console.WriteLine("Waiting for someone");
        }

        public static void Bye()
        {
            Console.WriteLine("Guuud bye! =)");
        }
    
}
/*  class Bicycle : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Boat : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("Boat is moving");
        }
        
    }

    interface IPrey
    {
        void Flee();
    }

    interface IPredator
    {
        void Hunt();
    }

    class Rabbit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("Rabbit runs away");
        }
    }

    class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("Hawk is looking for food");
        }
    }

    class Fish : IPrey, IPredator
    {
        public void Flee()
        {
            Console.WriteLine("Fish swims away");
        }

        public void Hunt()
        {
            Console.WriteLine("Fish is looking for smaller fish");
        }
    } */
/* class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("this animal goes *brrr*");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog goes *woof*");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog goes *meow*");
        }
    } */

/* class Vehicle
{
    public virtual void Go()
    {

    }
}



class Car : Vehicle
{
    public override void Go()
    {
        Console.WriteLine("Car is moving");
    }
    /* public String model;
    public String make;
    public int year;
    public String color;

    public Car(String model, String make, int year, String color)
    {
        this.model = model;
        this.make = make;
        this.year = year;
        this.color = color;

    }

    public override string ToString()
    {
        return "This is " + model + " " + make;
    } */

