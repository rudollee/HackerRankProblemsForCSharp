using System;
using System.Collections.Generic;
using HackerRankProblemsForCSharp.Results;

namespace HackerRankProblemsForCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void TestForMiniMaxSum()
        {
            var intArray = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Random rnd = new Random();
                int randomNum = rnd.Next();
                intArray.Add(int.MaxValue - randomNum);
                Console.WriteLine(intArray[i]);
            }
            Result.miniMaxSum(intArray);
        }

    }
}
