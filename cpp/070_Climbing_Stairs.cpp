// F(n) = F(n - 1) + F(n - 2): can take 1 or 2 step forward
// class Solution {
// public:
//     int climbStairs(int n) {
//         vector<int> dp(n + 2);
//         dp[0] = 1;
//         dp[1] = 1;
//         for (int i = 2; i <= n; i++) {
//             dp[i] = dp[i-1] + dp[i-2];
//         }
//         return dp[n];
//     }
// };

// F(n) = F(n - 1) + F(n - 2): can take 1 or 2 step forward
// F(n - 1), F(n - 2) replace by variable to reduce space
class Solution {
public:
    int climbStairs(int n) {
        int minus_one = 1, minus_two = 1, result = 1; 
        for (int i = 2; i <= n; i++) {
            result = minus_one + minus_two;
            minus_two = minus_one;
            minus_one = result;
        }
        return result;
    }
};