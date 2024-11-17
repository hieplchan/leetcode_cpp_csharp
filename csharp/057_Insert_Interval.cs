public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        List<int[]> result = new List<int[]>();
        bool isNewIntervalAdded = false;

        foreach(var interval in intervals) {
            if (isNewIntervalAdded) {
                result.Add(interval);
            } else if (newInterval[1] < interval[0]) {
                result.Add(newInterval);
                result.Add(interval);
                isNewIntervalAdded = true;
            } else if (interval[1] < newInterval[0]) {
                result.Add(interval);
            } else {
                newInterval[0] = Math.Min(newInterval[0], interval[0]);
                newInterval[1] = Math.Max(newInterval[1], interval[1]);
            }
        }

        if (!isNewIntervalAdded) result.Add(newInterval);

        return result.ToArray();
    }
}