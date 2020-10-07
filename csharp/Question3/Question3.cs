using System;
using System.Collections.Generic;
using System.Linq;


class Solution
{

    public static string findMinDays(int n,int d, int[] prices,int[] profits)
    {
        //Participants will add code here
        return "";
    }


    static void Main(String[] args)
    {
        // format input
        var line1 = Console.ReadLine().Split(' ');
        int n = int.Parse(line1[0]);
        int d = int.Parse(line1[1]);
        var line2 = Console.ReadLine().Split(' ');
        int[] prices = line2.Select(x => int.Parse(x)).ToArray();
        var profits = new List<int>();
        for (int i = 0; i < d; i++)
        {
            var profit = Console.ReadLine();
            profits.Add(int.Parse(profit));
        }
        string answer = findMinDays(n, d, prices,profits);
        // Do not remove below line
        Console.WriteLine(answer);
        // Do not print anything after this line
    }
}