// O(NLogK)
class Solution {
public:
    vector<int> topKFrequent(vector<int>& nums, int k) {
        unordered_map<int, int> m;
        vector<int> result;
        priority_queue<pair<int, int>> q;

        for (auto num : nums) m[num]++; // calculate frequency
        for (auto num : m) q.push({num.second, num.first}); // use heap to sort frequency
        while (k--) {
            result.push_back(q.top().second);
            q.pop();
        }           

        return result;
    }
};