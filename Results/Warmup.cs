using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblemsForCSharp.Results
{
    internal partial class Result
    {
        #region Alice and Bob - Compare Triplets
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            var scores = new List<int>() { 0, 0 };
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] == b[i]) continue;
                else if (a[i] > b[i]) scores[0]++;
                else scores[1]++;
            }

            return scores;
        }
        #endregion

        #region A Very Big Sum
        public static long aVeryBigSum(List<long> ar)
        {
            return ar.Sum();
        }
        #endregion

        #region Diagonal Difference
        public static int diagonalDifference(List<List<int>> arr)
        {
            int leftToRightSum = 0;
            int rightToLeftSum = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                leftToRightSum += arr[i][i];
                rightToLeftSum += arr[arr.Count - i - 1][i];
            }

            return Math.Abs(leftToRightSum - rightToLeftSum);
        }
        #endregion

        #region Staircase
        public static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                var x = string.Empty;
                Console.WriteLine($"{x.PadLeft(n - 1 - i, ' ')}{x.PadRight(i + 1, '#')}");
            }
        }
        #endregion

        #region Mini-Max Sum
        public static void miniMaxSum(List<int> arr)
        {
            arr.Sort();
            long min = 0;
            foreach (var n in arr.Take(4))
            {
                min += n;
            }
            long max = 0;
            foreach (var n in arr.Skip(1))
            {
                max += n;
            }
            Console.WriteLine($"{min} {max}");
        }
        #endregion

        #region Birthday Cake Candles
        public static int birthdayCakeCandles(List<int> candles)
        {
            int candleTallest = 0;
            int tallestCandleNumber = 0;
            foreach (var tall in candles)
            {
                if (tall > candleTallest)
                {
                    candleTallest = tall;
                    tallestCandleNumber = 1;
                }
                else if (tall == candleTallest)
                {
                    tallestCandleNumber++;
                }
            }

            return tallestCandleNumber;
        }
        #endregion

        #region Time Conversion
        public static string timeConversion(string s)
        {
            return DateTime.Parse(s).ToString("HH:mm:ss");
        }
        #endregion
    }
}
