class Solution {
public:
    vector<vector<int>> subsets(vector<int>& nums) {
        vector<vector<int>> result;
        
        result.push_back({});
        for (auto num : nums) {
            vector<vector<int>> newResult;
            for (auto prev : result) {
                vector<int> newSet(prev);
                newSet.push_back(num);
                newResult.push_back(newSet);
            }
            result.insert(result.end(), newResult.begin(), newResult.end());
        }

        return result;
    }
};