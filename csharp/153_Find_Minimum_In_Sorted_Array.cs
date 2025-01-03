public class Solution {
    public int FindMin(int[] nums) {
        int left = 0, right = nums.Length - 1;

        while (left < right) {
            // already sorted
            if (nums[left] < nums[right])
                return nums[left];
            
            int mid = (left + right) / 2;
            if (nums[mid] > nums[right])
                left = mid + 1;
            else
                right = mid;
        }
        
        return nums[left];
    }
}