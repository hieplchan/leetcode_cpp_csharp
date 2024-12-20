public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> m = new HashSet<int>();

        foreach (int num in nums) {
            if (m.Contains(num))
                return true;
            else
                m.Add(num);
        }

        return false;
    }
}