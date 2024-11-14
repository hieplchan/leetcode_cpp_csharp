public class Solution {
    public int MaxArea(int[] height) {
        int maxWater = 0;

        int left = 0, right = height.Length - 1;
        while (left < right) {
            int currWater = Math.Min(height[left], height[right]) * (right - left);
            maxWater = Math.Max(maxWater, currWater);
            if (height[left] < height[right]) {
                left++;
            } else {
                right--;
            }
        }

        return maxWater;
    }
}