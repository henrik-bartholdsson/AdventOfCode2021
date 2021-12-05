using System;
using System.IO;

namespace Day1.Solutions
{
    public class Day1
    {
        public void Run()
        {
            string[] lines = File.ReadAllLines("input.txt");
            string preveusLine = "0";
            int count = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(i);
                if (i >= lines.Length - 3)
                    break;

                if (Sum(
                    int.Parse(lines[i]),
                    int.Parse(lines[i + 1]),
                    int.Parse(lines[i + 2])
                    ) <
                    Sum(
                    int.Parse(lines[i + 1]),
                    int.Parse(lines[i + 2]),
                    int.Parse(lines[i + 3])))
                {
                    Console.WriteLine("Index=" + (i + 3));
                    count++;
                }
            }

            Console.WriteLine("Count=" + count);
            Console.ReadLine();
        }

        public static int Sum(int A, int B, int C)
        {
            return A + B + C;
        }
    }
}









