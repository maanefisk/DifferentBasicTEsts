using System;

namespace DifferentBasicTEsts
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test6 Multiplication of users 3 entered numbers
            Console.WriteLine("Enter first number: ");
            int answer1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int answer2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            int answer3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entered numbers multiplied: " + answer1 + " * " + answer2 + " * " + answer3 + " = " + (answer1*answer2*answer3) + "\n");

            //Test5 Swap two numbers (plus parse takes string value and makes it an int)
            int firstNumber, secondNumber, storingNumber;
            Console.WriteLine("Your first number: ");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Your second number: ");
            secondNumber = int.Parse(Console.ReadLine());
            storingNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = storingNumber;
            Console.WriteLine("After swapping:");
            Console.WriteLine("First number: "+firstNumber);
            Console.WriteLine("Second number: " + secondNumber + "\n");

            //Test4 Some random numbers
            Console.WriteLine("Enter your special number: ");
            int numbr4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your lottery ticket: ");
            Console.WriteLine(((-1+4*6)+numbr4)+" "+(((35+5)%7)*numbr4) + " " +((14+-4*6/11)/numbr4) + " " +((2+15/6*1-7%2)*numbr4));
            Console.WriteLine();

            //Test3 Dividing two numbers
            Console.WriteLine("Enter a number: ");
            int numbr3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your number / 2 = " + (numbr3/2));
            Console.WriteLine();

            //Test2 The sum of two numbers
            Console.WriteLine("Enter another number: ");
            int numbr1 = Convert.ToInt32(Console.ReadLine());
            int numbr2 = 5;

            
            Console.WriteLine("Your number + 5 = " + (numbr1 + numbr2));
            Console.WriteLine();

            //Test1 Write out name and hello in separate line.
            Console.Write("Write your name, please: ");
            var nameInput = Console.ReadLine();
            

            //Generate a story
            Console.WriteLine("Hello: " + nameInput + "!");
            Console.WriteLine("You like " + numbr1 + " types of food");
            Console.WriteLine("And " + numbr3 + " types of drinks");
        }
    }
}
