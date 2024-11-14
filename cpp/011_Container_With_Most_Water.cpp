class Solution {
public:
    int maxArea(vector<int>& height) {
        int maxArea = 0;

        size_t left = 0;
        size_t right = height.size() - 1;

        int a, b;

        // area = WxH -> loop throught max W to 0 to find optimal H
        while (left < right) {
            int currArea = min(height[right], height[left]) * (right - left);
            maxArea = max(maxArea, currArea);
            if (height[left] < height[right])
                left++;
            else
                right--;
        }

        return maxArea;
    }
};