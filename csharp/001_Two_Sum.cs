public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dic = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int temp = target - nums[i];
            if (dic.ContainsKey(temp)) {
                return new int[] { dic[temp], i };
            }
            dic[nums[i]] = i;
        }

        return new int[0];
    }
}