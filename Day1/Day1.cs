using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;

namespace AdventOfCode2022.Day1
{
    public class Day1
    {
        public void Day1Controller()
        {
            string filePath = @"C:\Users\olofsemm\source\repos\Emma\AdventOfCode2022\Day1\input.txt";
            List<string> inputValues = new List<string>();
            inputValues = File.ReadAllLines(filePath).ToList();
            List<string> divideInputs = new List<string>();
            List<int> summedValues = new List<int>();

            foreach (var value in inputValues)
            {
                if (value == "")
                {
                    int sum = divideInputs.ConvertAll(Convert.ToInt32).Sum();
                    summedValues.Add(sum);
                    divideInputs.Clear();
                    continue;
                }
                divideInputs.Add(value);
            }

            summedValues.Sort((x, y) => y.CompareTo(x));
            var firstThreeElements = summedValues.Take(3);
            var totalSum = firstThreeElements.Sum();
            totalSum.ToString();

            Console.WriteLine("Top 3 elves sum of calories:");
            Console.WriteLine(string.Join(Environment.NewLine, totalSum));
            Console.WriteLine("List of how many calories are being carried by each elf:");
            Console.Write(string.Join(Environment.NewLine, summedValues));
            Console.ReadLine();
        }        
    }
}
