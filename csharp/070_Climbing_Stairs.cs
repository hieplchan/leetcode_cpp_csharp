// public class Solution {
//     public int ClimbStairs(int n) {
//         int[] dp = new int[n + 2];
//         dp[0] = 1;
//         dp[1] = 1;
//         for (int i = 2; i <= n; i++) {
//             dp[i] = dp[i-1] + dp[i-2];
//         }
//         return dp[n];
//     }
// }

public class Solution {
    public int ClimbStairs(int n) {
        int minus_one = 1, minus_two = 1, result = 1;
        for (int i = 2; i <= n; i++) {
            result = minus_one + minus_two;
            minus_two = minus_one;
            minus_one = result;
        }
        return result;
    }
}