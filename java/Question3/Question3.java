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
            answer = findMinDays(values,profit);
            // Do not remove below line
            System.out.println(answer);
            // Do not print anything after this line
        }
    }

    public static String findMinDays(int[] values, int[] profit) {

        // Participant's code will go here
        return "";

    }
}