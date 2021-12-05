using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string regexWords = @"([\:]{2}|[\*]{2})(?<emojies>[A-Z][a-z][a-z]+)(\1)";
            string regexNumbers = @"(?<numbers>[0-9])";
            string text = Console.ReadLine();

            int coolThreshold = 1;
            Dictionary<string, int> emojies = new Dictionary<string, int>();
            MatchCollection matchesWords = Regex.Matches(text, regexWords);
            MatchCollection matchesNums = Regex.Matches(text, regexNumbers);
            foreach (Match VARIABLE in matchesNums)
            {
                coolThreshold *= int.Parse(VARIABLE.Groups["numbers"].Value);
            }

            foreach (Match VARIABLE in matchesWords)
            {
                int emojiValidator = 0;
                for (int i = 0; i < VARIABLE.Groups["emojies"].Length; i++)
                {
                    char index = VARIABLE.Groups["emojies"].Value[i];
                    emojiValidator += index;
                }
                emojies.Add(VARIABLE.Value, emojiValidator);
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{emojies.Count} emojis found in the text. The cool ones are:");
            foreach (var item in emojies)
            {
                if (item.Value > coolThreshold)
                {
                    Console.WriteLine(item.Key);
                }
            }
            

        }
    }
}
