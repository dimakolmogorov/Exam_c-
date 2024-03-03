using System;

class Program
{
    static void Main()
    {
        string[] inputArray = new string[] { "Hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia","Denmark"};
        string[] outputArray = new string[inputArray.Length];

        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                outputArray[i] = inputArray[i];
            }
        }

        for (int i = 0; i < outputArray.Length; i++)
        {
            Console.WriteLine(outputArray[i]);
        }
    }
}

