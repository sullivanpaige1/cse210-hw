using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> words = new List<int>();

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (Press 0 to exit): ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                words.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in words)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

                float average = ((float)sum) / words.Count;
        Console.WriteLine($"The average is: {average}");
        
        int max = words[0];

        foreach (int number in words)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}
