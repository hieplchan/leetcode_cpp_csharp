class Solution {
public:
    vector<vector<int>> merge(vector<vector<int>>& intervals) {
        if (intervals.size() == 0) return vector<vector<int>>();

        sort(intervals.begin(), intervals.end(), [](vector<int>& a, vector<int>& b) {
            return a[0] < b[0];
        });

        vector<vector<int>> res;

        for (int i = 1; i < intervals.size(); i++) {
            if (intervals[i-1][1] >= intervals[i][0]) {
                // overlap
                intervals[i][0] = intervals[i-1][0];
                intervals[i][1] = max(intervals[i-1][1], intervals[i][1]);
            } else {
                res.push_back(intervals[i-1]);
            }
        }
        res.push_back(intervals.back());

        return res;
    }
};