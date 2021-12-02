﻿using System;
using System.IO;
using System.Linq;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "input.txt";

            if (!File.Exists(file))
            {
                Console.WriteLine("File doesn't exist");
                return;
            }
            //First step
            FirstStep(file);

            //second step
            SecondStep(file);
        }

        private static void SecondStep(string file)
        {
            int x = 0;
            int y = 0;
            int aim = 0;
            var values = File.ReadLines(file).ToList();

            foreach (string value in values)
            {
                var splitted = value.Split(' ');
                if (int.TryParse(splitted[1], out int command))
                {
                    switch (splitted[0].ToLower())
                    {
                        case "up":
                            aim -= command;
                            break;
                        case "down":
                            aim += command;
                            break;
                        case "forward":
                            x += command;
                            if(aim != 0)
                                y += aim * command;
                            break;
                    }
                }
            }

            int r = x * y;
            Console.WriteLine($"horrizontal: {x} vertical: {y} total: {r}");
        }

        private static void FirstStep(string file)
        {
            int x = 0;
            int y = 0;
            var values = File.ReadLines(file).ToList();
            foreach (string value in values)
            {
                var splitted = value.Split(' ');
                if (int.TryParse(splitted[1], out int command))
                {
                    switch (splitted[0].ToLower())
                    {
                        case "up":
                            y -= command;
                            break;
                        case "down":
                            y += command;
                            break;
                        case "forward":
                            x += command;
                            break;
                    }
                }
            }
            int r = x * y;
            Console.WriteLine($"horrizontal: {x} vertical: {y} total: {r}");
        }
    }
}
