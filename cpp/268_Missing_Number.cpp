class Solution {
public:
    int missingNumber(vector<int>& nums) {
        int index = 0, length = nums.size();

        // Cyclic Sort
        while (index < length) {
            int correctIndex = nums[index];
            if ((correctIndex < length) && (nums[index] != nums[correctIndex])) {
                swap(nums[index], nums[correctIndex]);
            } else {
                index++;
            }
        }

        // find missing
        for (int i = 0; i < nums.size(); i++) {
            if (nums[i] != i) return i;
        }

        return length;
    }
};