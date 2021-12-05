using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ad_Astra
{
    
    class Program
    {
        static void Main(string[] args)
        {
            string regex =
                @"(\||\#)(?<name>[a-zA-Z\s]+)\1(?<date>[0-9]{2}\/[0-9]{2}\/[0-9]{2})\1(?<calories>[0-9]+)\1";
            string input = Console.ReadLine();
            Regex newRegex = new Regex(regex);
            MatchCollection matches = newRegex.Matches(input);
            int totalCalories = 0;
            foreach (Match VARIABLE in matches)
            {
                totalCalories += int.Parse(VARIABLE.Groups["calories"].Value);
            }

            int totalDays = totalCalories / 2000;
            Console.WriteLine($"You have food to last you for: {totalDays} days!");
            foreach (Match VARIABLE in matches)
            {
                Console.WriteLine($"Item: {VARIABLE.Groups["name"].Value}, Best before: {VARIABLE.Groups["date"].Value}, Nutrition: {VARIABLE.Groups["calories"].Value}");
            }
        }
    }
}
