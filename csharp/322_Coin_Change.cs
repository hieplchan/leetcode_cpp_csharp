public class Solution {
    public int CoinChange(int[] coins, int amount) {
        Array.Sort(coins);
        
        int[] dp = Enumerable.Repeat(amount + 1, amount + 1).ToArray();
        dp[0] = 0;

        for (int i = 1; i <= amount; i++) {
            foreach (int coin in coins) {
                if (coin < i) {
                    dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                } else if (coin == i) {
                    dp[i] = 1;
                    break;
                } else {
                    break;
                }
            }
        }

        return dp[amount] == amount + 1 ? -1 : dp[amount];
    }
}