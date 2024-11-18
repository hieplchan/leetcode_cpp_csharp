public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int left = 0, right = left + 1;

        while (right < prices.Length) {
            if (prices[right] - prices[left] < 0) {
                left = right++;
            } else {
                maxProfit = Math.Max(maxProfit, prices[right++] - prices[left]);
            }
        }

        return maxProfit;
    }
}