using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace Solution
{
    class Solution
    {

        // You may change this function parameters
        static int FindMaxProfit(int numOfPredictedDays, int[] predictedSharePrices)
        {
            return -1;
        }

        static void Main(string[] args)
        {
            String[] firstLine = Console.ReadLine().Split(" ");

            int[] firstLineIntArr = Array.ConvertAll(firstLine, sTemp => Convert.ToInt32(sTemp));

            int numOfPredictedDays = firstLineIntArr[0];
            int[] predictedSharePrices = firstLineIntArr.Skip(1).ToArray();


            int result = FindMaxProfit(numOfPredictedDays, predictedSharePrices);

            // Do not remove this line
            Console.WriteLine(result);
            // Do not print anything after this line
        }
    }
}