import java.io.*;
import java.util.*;

class Solution {

    public static void main(String[] args) {

        try (Scanner scanner = new Scanner(System.in)) {
            int n = scanner.nextInt();
            int d = scanner.nextInt();
            String answer ="";
            int[] values = new int[n];
            int[] profit = new int[d];
            for (int i = 0; i < n; i++) {
                values[i] = scanner.nextInt();
            }

            for (int j = 0; j < d; j++) {
                profit[j] = scanner.nextInt();
            }
            answer = findMinDays(n, d, values,profit);
            // Do not remove below line
            System.out.println(answer);
            // Do not print anything after this line
        }
    }

    public static String findMinDays(int n, int d, int[] prices, int[] profits) {

        String stringToReturn = "";
        for(int k = 0; k < profits.length; k++){
            int iOfMinj = 0;
            int minj = 100001;
            for(int i = 0; i < n; i++){
                for(int j = i+1; j < n; j++){
                    if(prices[j]-prices[i] == profits[k]){
                        if(j <= minj){
                            iOfMinj = i;
                            minj = j;
                        }
                    }
                }
            }
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
}