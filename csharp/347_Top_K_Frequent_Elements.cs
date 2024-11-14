public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int[] result = new int[k];
        Dictionary<int, int> m = new Dictionary<int, int>();
        List<int> q = new List<int>();

        // Frequency calculate
        foreach (int num in nums) {
            if (!m.ContainsKey(num)) 
                m.Add(num, 1);
            else
                m[num]++;            
        }

        // sort frequency
        q = m.Keys.ToList();
        q.Sort(delegate(int x, int y) {
            return m[y].CompareTo(m[x]);
        });

        // get k result
        for (int i = 0; i < k; i++) {
            result[i] = q[i];
        }

        return result;
    }
}