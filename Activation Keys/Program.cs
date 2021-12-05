using System;

namespace Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawActivationKey = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "Generate")
            {
                string[] currCommand = command.Split(">>>");
                if (currCommand[0] == "Contains")
                {
                    string substring = currCommand[1];
                    if (rawActivationKey.Contains(substring))
                    {
                        Console.WriteLine($"{rawActivationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }

                    
                }
                else if (currCommand[0] == "Flip")
                {
                    int startIndex = int.Parse(currCommand[2]);
                    int endIndex = int.Parse(currCommand[3]);
                    string upLow = currCommand[1];
                    if (upLow == "Upper")
                    {
                        string text = String.Empty;
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            text += rawActivationKey[i];
                        }

                        int index = rawActivationKey.IndexOf(text);
                        rawActivationKey = rawActivationKey.Remove(index, text.Length);
                        text = text.ToUpper();
                        rawActivationKey = rawActivationKey.Insert(index, text);
                    }
                    else if (upLow == "Lower")
                    {
                        string text = String.Empty;
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            text += rawActivationKey[i];
                        }

                        int index = rawActivationKey.IndexOf(text);
                        rawActivationKey = rawActivationKey.Remove(index, text.Length);
                        text = text.ToLower();
                        rawActivationKey = rawActivationKey.Insert(index, text);
                    }
                    Console.WriteLine(rawActivationKey);
                }
                else if (currCommand[0] == "Slice")
                {
                    int startIndex = int.Parse(currCommand[1]);
                    int endIndex = int.Parse(currCommand[2]);
                    rawActivationKey = rawActivationKey.Remove(startIndex, endIndex-startIndex);
                    Console.WriteLine(rawActivationKey);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {rawActivationKey}");
        }
    }
}
