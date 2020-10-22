

using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{

    public static string findMinDays(int n,int d, int[] prices, List<int> profits)
    {
        //Participants will add code here
        string stringToReturn = "";
        for(int k = 0; k < profits.Count; k++){
            int iOfMinj = 0;
            int minj = 100001;
            for(int i = 0; i < n; i++){
                for(int j = i+1; j < n; j++){
                    if(prices[j]-prices[i] == profits[k]){
                        if(j <= minj){
                            iOfMinj = i;
                            minj = j;
                        }
                        //Console.WriteLine("{0} {1} {2} {3} {4} {5}", prices[i], prices[j], prices[j]-prices[i], i+1, j+1, profits[k]);
                        
                    }
                }
            }
            //Console.WriteLine("Ha: {0} {1} {2} {3} {4} {5}", prices[iOfMinj], prices[minj], prices[minj]-prices[iOfMinj], iOfMinj+1, minj+1, profits[k]);
            if(minj != 100001){
                if(k > 0) 
                    stringToReturn = stringToReturn + ",";
                stringToReturn = stringToReturn + (iOfMinj+1) + " " + (minj+1);
            }else{
                if(k > 0) 
                    stringToReturn = stringToReturn + ",";
                stringToReturn = stringToReturn + "-1";
            }
        }
        return stringToReturn;
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
