class Solution {
public:
    vector<vector<int>> insert(vector<vector<int>>& intervals, vector<int>& newInterval) {
        vector<vector<int>> result;

        for (auto interval : intervals) {
            if (newInterval.empty()) { 
                // already added
                result.push_back(interval);
            } else if (newInterval[0] > interval[1]) {
                // no overlap, interval < newInterval
                result.push_back(interval);
            } else if (newInterval[1] < interval[0]) {
                // no overlap, newInterval < interval
                result.push_back(newInterval);
                result.push_back(interval);
                newInterval.clear();
            } else {
                // overlap
                newInterval[0] = min(newInterval[0], interval[0]);
                newInterval[1] = max(newInterval[1], interval[1]);
            }
        }

        if (!newInterval.empty()) result.push_back(newInterval);

        return result;
    }
};