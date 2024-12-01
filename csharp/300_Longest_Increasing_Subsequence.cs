// DP: O(n^2)
public class Solution {
    public int LengthOfLIS(int[] nums) {
        int[] dp = Enumerable.Repeat(1, nums.Length).ToArray();
        int maxLength = 1;

        for (int i = 1; i < nums.Length; i++) {
            for (int j = 0; j < i; j++) {
                if (nums[i] > nums[j]) {
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                    maxLength = Math.Max(maxLength, dp[i]);
                }
            }
        }

        return maxLength;
    }
}

// Binary Search O(nlogn)
public class Solution {
    public int LengthOfLIS(int[] nums) {
        List<int> dp = new List<int>();
        dp.Add(nums[0]);

        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] > dp.Last()) {
                dp.Add(nums[i]);
                continue;
            }
            
            int pos = dp.BinarySearch(nums[i]);
            if (pos < 0) {
                dp[~pos] = nums[i];
            }
        }

        return dp.Count;
    }
}