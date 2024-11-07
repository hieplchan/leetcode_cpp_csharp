public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, (val1, val2) => val1[0].CompareTo(val2[0]));

        List<int[]> res = new List<int[]>();
        for (int i = 1; i < intervals.Length; i++) {
            if (intervals[i-1][1] >= intervals[i][0]) {
                intervals[i][0] = intervals[i-1][0];
                intervals[i][1] = Math.Max(intervals[i-1][1], intervals[i][1]);
            } else {
                res.Add(new int[] { intervals[i-1][0], intervals[i-1][1] });
            }
        }
        res.Add(new int[] { intervals[intervals.Length - 1][0], intervals[intervals.Length - 1][1] });

        return res.ToArray();
    }
}