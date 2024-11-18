class Solution {
public:
    int maxProfit(vector<int>& prices) {
        int maxProfit = 0;

        int left = 0, right = left + 1;
        while (right < prices.size()) {
            if (prices[right] - prices[left] < 0) {
                left = right;
                right = left + 1;
            } else {
                maxProfit = max(maxProfit, prices[right] - prices[left]);
                right++;
            }
        }

        return maxProfit;
    }
};