﻿using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[5];
        int sum = 0;
	int number;

        Console.WriteLine("Enter 5 numbers:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Number {i + 1}: ");
            string input = Console.ReadLine();
	        number = Convert.ToInt32(input);
            sum += number;
        }

        Console.WriteLine($"The sum of the numbers is: {sum}");
    }
}
