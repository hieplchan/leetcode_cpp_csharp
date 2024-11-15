class Solution {
public:
    vector<vector<int>> threeSum(vector<int>& nums) {
        unordered_map<int, int> map;
        set<vector<int>> result;
        
        sort(nums.begin(), nums.end());
        for (auto num : nums)
            map[num] = 1;

        for (int i = 0; i < nums.size() - 2; i++) {
            if ((i > 0) && (nums[i] == nums[i - 1])) continue;
            for (int j = i + 1; j < nums.size() - 1; j++) {
                int k = -nums[i] - nums[j];
                if ((k < nums[i]) || (k < nums[j])) continue;
                if (map.count(k)) { // if third number existed
                    result.insert({nums[i], nums[j], -nums[i] - nums[j]});
                }
            }
        }

        vector<vector<int>> res(result.begin(), result.end());
        return res;
    }
};