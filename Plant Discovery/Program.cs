using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<int, List<double>>> plants = new Dictionary<string, Dictionary<int, List<double>>>();
            
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] currPlant = input.Split("<->");
                string plantName = currPlant[0];
                int rarity = int.Parse(currPlant[1]);
                if (plants.ContainsKey(plantName))
                {
                    plants[plantName] = new Dictionary<int, List<double>>();
                    plants[plantName].Add(rarity, new List<double>());
                }
                else
                {
                    plants.Add(plantName, new Dictionary<int, List<double>>());
                    plants[plantName].Add(rarity, new List<double>());
                }
                
            }

            string command = Console.ReadLine();
            while (command != "Exhibition")
            {
                string[] currCommand = command.Split();
                if (currCommand[0].Contains("Rate"))
                {
                   
                }
                else if (currCommand[0].Contains("Update"))
                {
                    if (plants.ContainsKey(currCommand[1]))
                    {
                        plants[currCommand[1]] = new Dictionary<int, List<double>>();
                        plants[currCommand[1]].Add(int.Parse(currCommand[3]), new List<double>());
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (currCommand[0].Contains("Reset"))
                {
                    if (plants.ContainsKey(currCommand[1]))
                    {
                        plants[currCommand[1]].Clear();
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine("Plants for the exhibition:");

            
        }
    }
}
