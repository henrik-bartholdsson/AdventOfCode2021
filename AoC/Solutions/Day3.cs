using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdventOfCode.Solutions
{
    public class Day3
    {
        public void Run()
        {
            int[] frequence = new int[12];
            var binaryArray = GetArray();

            //PrintArray(binaryArray);

            var alsdj = binaryArray.Length;

            for (int i = 0; i < 1000; i++)
            {
                for(int j = 0; j < 12; j++)
                {
                    //Console.WriteLine(i + " - " + j + " = " + binaryArray[i,j]);

                    if (binaryArray[i, j] == 1)
                        frequence[j]++;
                    else
                        frequence[j]--;
                }
            }

            Console.WriteLine("------------------------");
            Console.WriteLine();
            foreach (int i in frequence)
            {
                if (i > 0)
                    Console.Write(1);
                else
                    Console.Write(0);
            }
            Console.WriteLine();
            foreach (int i in frequence)
            {
                if (i > 0)
                    Console.Write(0);
                else
                    Console.Write(1);
            }
        }


        public int[,] GetArray()
        {
            string[] lines = File.ReadAllLines("PowerConsumption.txt");
            int[,] arrayToReturn = new int[1000, 12];
            int i = 0;
            int j = 0;

            foreach (string line in lines)
            {
                foreach (var b in line)
                {
                    arrayToReturn[i, j] = int.Parse(b.ToString());
                    j++;
                }
                i++;
                j = 0;
            }

            return arrayToReturn;
        }

        public void PrintArray(int[,] arr)
        {
            for(int i = 0; i< 1000; i++)
            {
                for(int j = 0; j < 12; j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
