// DP: O(n^2)
class Solution {
public:
    int lengthOfLIS(vector<int>& nums) {
        vector<int> dp(nums.size(), 1);
        int maxLength = 1;

        for (int i = 1; i < nums.size(); i++) {
            for (int j = 0; j < i; j++) {
                if (nums[i] > nums[j]) {
                    dp[i] = max(dp[i], dp[j] + 1);
                    maxLength = max(maxLength, dp[i]);
                }
            }
        }

        return maxLength;
    }
};

// Binary Search O(nlogn)
class Solution {
public:
    int lengthOfLIS(vector<int>& nums) {
        vector<int> dp;
        dp.push_back(nums[0]);

        for (int i = 0; i < nums.size(); i++) {
            if (nums[i] > dp.back()) {
                dp.push_back(nums[i]);
                continue;
            }

            auto pos = lower_bound(dp.begin(), dp.end(), nums[i]);
            if (pos < dp.end()) {
                *pos = nums[i];
            }
        }

        return dp.size();
    }
};


