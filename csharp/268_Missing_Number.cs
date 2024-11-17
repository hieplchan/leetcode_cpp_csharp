public class Solution {
    public int MissingNumber(int[] nums) {
        int index = 0, length = nums.Length;

        // Cyclic Sort
        while (index < length) {
            int correctIndex = nums[index];
            if ((correctIndex < length) && (nums[index] != nums[correctIndex])) {
                int temp = nums[correctIndex];
                nums[correctIndex] = nums[index];
                nums[index] = temp;
            } else {
                index++;
            }
        }

        // find missing
        for (int i = 0; i < length; i++) {
            if (nums[i] != i) return i;
        }

        return nums.Length;
    }
}