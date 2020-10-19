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
        
        static int FindMaxProfit(int numOfPredictedTimes, int[] predictedSharePrices)
        {
            // Participant's code will go here

            int max = 0;
            for(int start = 2; start < numOfPredictedTimes; start++){
                int[, ] sum = new int[start + 1, numOfPredictedTimes + 1]; 
          
                for (int i = 0; i <= start; i++) 
                    sum[i, 0] = 0; 
          
                for (int j = 0; j <= numOfPredictedTimes; j++) 
                    sum[0, j] = 0; 
          
                for (int i = 1; i <= start; i++) { 
                    for (int j = 1; j < numOfPredictedTimes; j++) { 
                        int max_so_far = 0; 
                        for (int m = 0; m < j; m++) 
                        max_so_far = Math.Max(max_so_far, predictedSharePrices[j] - 
                                       predictedSharePrices[m] + sum[i - 1, m]); 
                        sum[i, j] = Math.Max(sum[i, j - 1], max_so_far); 
                    } 
                } 
                max = sum[start, numOfPredictedTimes - 1] > max ? sum[start, numOfPredictedTimes - 1] : max;
            }
            return max; 

        }

        static void Main(string[] args)
        {
            String[] firstLine = Console.ReadLine().Split(" ");

            int[] firstLineIntArr = Array.ConvertAll(firstLine, sTemp => Convert.ToInt32(sTemp));

            int numOfPredictedTimes = firstLineIntArr[0];
            int[] predictedSharePrices = firstLineIntArr.Skip(1).ToArray();

            int result = FindMaxProfit(numOfPredictedTimes, predictedSharePrices);

            // Please do not remove the below line.
            Console.WriteLine(result);
            // Do not print anything after this line
        }
    }
}