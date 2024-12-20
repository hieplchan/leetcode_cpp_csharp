class Solution {
public:
    bool containsDuplicate(vector<int>& nums) {
        unordered_set<int> m;
        for (int num : nums) {
            if (m.contains(num)) {
                return true;
            } else {
                m.insert(num);
            }
        }
        return false;
    }
};