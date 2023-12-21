using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a text:");

        string inputText = Console.ReadLine();

        int countA = 0;

        for (int i = 0; i < inputText.Length; i++)
        {
            if (inputText[i] == 'A')
            {
                countA++;
            }
        }

        Console.WriteLine($"A appears {countA} times");
    }
}
