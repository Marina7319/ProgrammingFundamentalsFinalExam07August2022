﻿using System;

namespace _01.DecryptingCommands
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string inputLine = Console.ReadLine();
            while (inputLine != "Finish")
            {
                string[] commands = inputLine.Split(" ");
                string command = commands[0];
                switch (command)
                {
                    case "Replace":
                        string currentChar = commands[1];
                        string newString = commands[2];
                        input = input.Replace(currentChar, newString);
                        Console.WriteLine(input);
                        break;
                    case "Cut":
                        int startIndex = int.Parse(commands[1]);
                        int endIndex = int.Parse(commands[2]);
                        if (input.Length >= endIndex && startIndex >= 0)
                        {
                            input = input.Remove(startIndex, endIndex - startIndex + 1);
                            Console.WriteLine(input);
                        }
                        else
                        {
                            Console.WriteLine("Invalid indices!");
                        }
                        break;
                    case "Make":
                        string upperOrLowerCommand = commands[1];
                        if (upperOrLowerCommand == "Upper")
                        {
                            input = input.ToUpper();
                        }
                        else
                        {
                            input = input.ToLower();
                        }
                        Console.WriteLine(input);
                        break;
                    case "Check":
                        string containsString = commands[1];
                        if (input.Contains(containsString))
                        {
                            Console.WriteLine($"Message contains {containsString}");
                        }
                        else
                        {
                            Console.WriteLine($"Message doesn't contain {containsString}");
                        }
                        break;
                    case "Sum":
                        int startNumber = int.Parse(commands[1]);
                        int endNumber = int.Parse(commands[2]);
                        int sum = 0;
                        if (startNumber >= 0 && endNumber < input.Length)
                        {
                            for (int i = startNumber; i <= endNumber; i++)
                            {
                                sum += (char)input[i];
                            }
                            Console.WriteLine(sum);
                        }
                        else
                        {
                            Console.WriteLine("Invalid indices!");
                        }
                        break;
                }
                inputLine = Console.ReadLine();
            }
        }
    }
}
//ILikeSoftUni
//    Replace I We
//    Make Upper
//    Check SoftUni
//    Sum 1 4
//    Cut 1 4
//    Finish