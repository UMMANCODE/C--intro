﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a text:");

        string inputText = Console.ReadLine();

	bool has = false;
        for (int i = 0; i < inputText.Length; i++)
        {
            if (inputText[i] == 'A')
            {
                has = true;
		break;
            }
        }
	if (has)
        Console.WriteLine("There is A");
	else
        Console.WriteLine("There is not any A");
    }
}
