using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdventOfCode.Solutions
{
    public class Day2
    {
        int forward = 0;
        int dept = 0;

        int aim = 0;

        public void Run()
        {
            string[] lines = File.ReadAllLines("inputPlot.txt");

            foreach (string line in lines)
            {
                var a = line.Split(' ');
                Console.WriteLine(a[1]);

                switch (a[0])
                {
                    case "forward":
                        Forward(int.Parse(a[1]));
                        break;
                    case "down":
                        Down(int.Parse(a[1]));
                        break;
                    case "up":
                        Up(int.Parse(a[1]));
                        break;
                    default:
                        Console.WriteLine("Error: " + a[0]);
                        Console.ReadKey();
                        break;

                }  
            }

            Console.WriteLine("Result: " + (dept * forward));
            Console.WriteLine("Aim: {0}. Forward: {1}", aim, forward);
        }

        public void Forward(int nr)
        {
            Console.WriteLine("Moving {0} units forward.", nr);
            forward += nr;
            dept = dept + (aim * nr);
        }

        public void Down(int nr)
        {
            aim += nr;
        }

        public void Up(int nr)
        {
            aim -= nr;
        }
    }
}
