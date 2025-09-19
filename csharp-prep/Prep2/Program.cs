using System;
using System.Formats.Asn1;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your overall grade score: ");
        string letterGrade = Console.ReadLine();
        int number = int.Parse(letterGrade);

        string sign = "";

        if (number >= 101)
        {
            Console.WriteLine("If this is your valid grade score then you have an A, but I would check again to confirm the number.");
        }
        else if ((number <= 100) && (number >= 90))
        {
            letterGrade = "A";
        }
        else if ((number < 90) && (number >= 80))
        {
            letterGrade = "B";
        }
        else if ((number < 80) && (number >= 70))
        {
            letterGrade = "C";
        }
        else if ((number < 70) && (number >= 60))
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        int lastDigit = number % 10;

        if (letterGrade != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        if (letterGrade == "A" && sign == "+")
        {
            sign = "";
        }

        Console.WriteLine($"You're grade letter score is: {letterGrade}{sign}");

        if (number >= 70)
        {
            Console.WriteLine("Congratulations! You are passing the course! Awesome job!");
        }
        else
        {
            Console.WriteLine("I'm sorry, you're not passing the class! Work with teachers and others, you can do it! You just need a C to pass!");
        }

    }
}