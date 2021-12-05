using System;
using System.Collections.Generic;
using System.Text;

namespace StringManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] currCommand = command.Split();
                if (currCommand[0] == "Translate")
                {
                    char currChar = char.Parse(currCommand[1]);
                    char replacement = char.Parse(currCommand[2]);
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] == currChar)
                        {
                            input = input.Replace(currChar, replacement);
                            
                        }
                    }
                    
                    Console.WriteLine(input);
                }
                else if (currCommand[0] == "Includes")
                {
                    string substring = currCommand[1];
                    if (input.Contains(substring))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (currCommand[0] == "Start")
                {
                    string substring = currCommand[1];
                    if (input.Contains(substring))
                    {
                        if (input.IndexOf(substring) == 0)
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (currCommand[0] == "Lowercase")
                {
                    input = input.ToLower();
                    Console.WriteLine(input);
                }
                else if (currCommand[0] == "FindIndex")
                {
                    Console.WriteLine(input.LastIndexOf(currCommand[1]));
                }
                else if (currCommand[0] == "Remove")
                {
                    int startIndex = int.Parse(currCommand[1]);
                    int count = int.Parse(currCommand[2]);
                    input = input.Remove(startIndex, count);
                    Console.WriteLine(input);
                }

                command = Console.ReadLine();
            }
        }
    }
}
