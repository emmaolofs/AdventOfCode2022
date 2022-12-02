using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2022.Day2
{
    public class Day2
    {
        public void Day2Controller()
        {
            string filePath = @"C:\Users\olofsemm\source\repos\Emma\AdventOfCode2022\Day2\input.txt";
            List<string> inputValues = new List<string>();
            inputValues = File.ReadAllLines(filePath).ToList();
            List<int> myPoints = new List<int>();
            List<int> myPointsRound2 = new List<int>();

            int win = 6;
            int loss = 0;
            int draw = 3;

            //solution problem 1
            foreach (var value in inputValues)
            {
                if (value.Contains("A "))
                {
                    if (value == "A Y")
                    {
                        int sum = win + 2;
                        myPoints.Add(sum);
                    }
                    else if (value == "A X")
                    {
                        int sum = draw + 1;
                        myPoints.Add(sum);

                    }
                    else if (value == "A Z")
                    {
                        int sum = loss + 3;
                        myPoints.Add(sum);
                    }
                }
                else if (value.Contains("B "))
                {
                    if (value == "B Y")
                    {
                        int sum = draw + 2;
                        myPoints.Add(sum);
                    }
                    else if (value == "B X")
                    {
                        int sum = loss + 1;
                        myPoints.Add(sum);

                    }
                    else if (value == "B Z")
                    {
                        int sum = win + 3;
                        myPoints.Add(sum);
                    }
                }
                else if (value.Contains("C "))
                {
                    if (value == "C Y")
                    {
                        int sum = loss + 2;
                        myPoints.Add(sum);
                    }
                    else if (value == "C X")
                    {
                        int sum = win + 1;
                        myPoints.Add(sum);

                    }
                    else if (value == "C Z")
                    {
                        int sum = draw + 3;
                        myPoints.Add(sum);
                    }
                }
            }

            //solution problem 2
            foreach (var value in inputValues)
            {
                if (value.Contains(" Y"))
                {
                    if (value == "A Y")
                    {
                        int sum = draw + 1;
                        myPointsRound2.Add(sum);
                    }
                    else if (value == "B Y")
                    {
                        int sum = draw + 2;
                        myPointsRound2.Add(sum);

                    }
                    else if (value == "C Y")
                    {
                        int sum = draw + 3;
                        myPointsRound2.Add(sum);
                    }
                }
                else if (value.Contains(" X"))
                {
                    if (value == "A X")
                    {
                        int sum = loss + 3;
                        myPointsRound2.Add(sum);
                    }
                    else if (value == "B X")
                    {
                        int sum = loss + 1;
                        myPointsRound2.Add(sum);

                    }
                    else if (value == "C X")
                    {
                        int sum = loss + 2;
                        myPointsRound2.Add(sum);
                    }
                }
                else if (value.Contains(" Z"))
                {
                    if (value == "A Z")
                    {
                        int sum = win + 2;
                        myPointsRound2.Add(sum);
                    }
                    else if (value == "B Z")
                    {
                        int sum = win + 3;
                        myPointsRound2.Add(sum);

                    }
                    else if (value == "C Z")
                    {
                        int sum = win + 1;
                        myPointsRound2.Add(sum);
                    }
                }
            }

            var totalSum = myPoints.Sum();
            var totalSumRound2 = myPointsRound2.Sum();

            Console.WriteLine("My total score Round1:");
            Console.WriteLine(string.Join(Environment.NewLine, totalSum));
            Console.WriteLine("My total score Round2:");
            Console.WriteLine(string.Join(Environment.NewLine, totalSumRound2));
            Console.ReadLine();
        }
    }
}
