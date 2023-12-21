﻿using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the type of education: ");
        string educationType = Console.ReadLine();

        switch (educationType.ToLower())
        {
            case "programming":
                Console.WriteLine("400 hours");
                break;
            case "design":
                Console.WriteLine("250 hours");
                break;
            case "system":
                Console.WriteLine("200 hours");
                break;
            default:
                Console.WriteLine("The type of education is wrong");
                break;
        }
    }
}
