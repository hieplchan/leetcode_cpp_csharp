public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        if (nums.Length == 0) return result;

        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++) {
            if ((i > 0) && (nums[i] == nums[i - 1])) continue; // already checked

            int left = i + 1, right = nums.Length - 1;
            while (left < right) {
                int sum = nums[i] + nums[left] + nums[right];
                if (sum < 0) {
                    left++;
                } else if (sum > 0) {
                    right--;
                } else {
                    List<int> temp = new List<int> {nums[i], nums[left++], nums[right--]};
                    result.Add(temp);

                    while ((left < right) && (nums[left] == nums[left - 1]))
                        left++;
                    while ((left < right) && (nums[right] == nums[right + 1])) 
                        right--;                
                }
            }
        }

        return result;
    }
}