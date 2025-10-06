using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int numbersInput;

        Console.WriteLine("Enter as many numbers as you would like. Enter 0 to stop.");

        do
        {
            Console.Write("Please enter a number: ");
            string addNumber = Console.ReadLine();

            if (int.TryParse(addNumber, out numbersInput))
            {
                if (numbersInput != 0)
                {
                    numbers.Add(numbersInput);
                }
                else
                {
                    Console.WriteLine("Thank you for your input. Here are the results!");
                }
            }
        }
        while (numbersInput != 0);

        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
        }



        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");

        int smallest = int.MaxValue;
        bool found = false;

        foreach (int num in numbers)
        {
            if (num > 0 && num < smallest)
            {
                smallest = num;
                found = true;
            }
        }

        if (found)
        {
            Console.WriteLine($"The smallest positive number is: {smallest}");
        }
        else
        {
            Console.WriteLine($"No positive numbers were entered.");
        }

        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}