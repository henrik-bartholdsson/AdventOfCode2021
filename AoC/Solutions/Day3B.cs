using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdventOfCode.Solutions
{
    public class Day3B
    {
        public void Run()
        {
            var binaryArray = GetArray();
            var binaryArray2 = GetArray();
            int val = 0;

            for (int i = 0; i < binaryArray.GetLength(1); i++)
            {
                val = GetMostCommonValue(binaryArray, i);
                binaryArray = ReturnValues(binaryArray, i, val);

                val = GetLeastCommonValue(binaryArray2, i);
                if(binaryArray2.GetLength(0) > 1)
                binaryArray2 = ReturnValues(binaryArray2, i, val);

            }



            foreach(var v in binaryArray)
                Console.Write(v.ToString());

            Console.WriteLine();

            foreach (var v in binaryArray2)
                Console.Write(v.ToString());


            Console.ReadKey();
        }

        public int[,] ReturnValues(int[,] arr, int index, int val)
        {
            var firstIndexLength = arr.GetLength(0);
            var secondIndexLength = arr.GetLength(1); //12

            int nrOfoVal = 0;
            for (int i = 0; i < firstIndexLength; i++)
            {
                if (arr[i, index] == val)
                    nrOfoVal++;
            }

            int newArrayIndexMem = 0;
            int[,] result = new int[nrOfoVal, secondIndexLength];

            for (int i = 0; i < firstIndexLength; i++)
            {
                if (arr[i, index] == val)
                {
                    for(int j = 0; j < secondIndexLength; j++)
                    {
                        result[newArrayIndexMem,j] = arr[i, j];
                    }
                    newArrayIndexMem++;
                }
            }

            return result;
        }

        public int GetMostCommonValue(int[,] arr, int index)
        {
            int nrOfZeros = 0;
            int nrOfOnes =0;
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                if(arr[i, index] == 1)
                    nrOfOnes++;
                else
                    nrOfZeros++;
            }

            if (nrOfOnes >= nrOfZeros)
                return 1;

            return 0;
        }

        public int GetLeastCommonValue(int[,] arr, int index)
        {
            int nrOfOnes = 0;
            int nrOfZeros = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[i, index] == 1)
                    nrOfOnes++;
                else
                    nrOfZeros++;
            }

            if (nrOfOnes < nrOfZeros)
                return 1;

            return 0;
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
