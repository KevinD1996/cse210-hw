using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;
        while (number != 0)
        {
            Console.WriteLine("You Could enter a number (O to quit): ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);

            }
            Console.WriteLine("\nNumbers you entered:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }


        }


        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;

        }
        Console.WriteLine($"The sum is: {sum}");

        if (numbers.Count > 0)
        {
            float averange = (float)sum / numbers.Count;
            Console.WriteLine($"The averange is: {averange}");
        }
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
                max = num;

        }

        Console.WriteLine($"The max is: {max}");

        int TheSmallestNumber = 99999999;
        foreach (int num in numbers)
        {
            if ((num > 0) && (num < TheSmallestNumber))
                TheSmallestNumber = num;

        }
        Console.WriteLine($"The Smallest positiv number is: {TheSmallestNumber}");

        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }

    
}