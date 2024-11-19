public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        List<IList<int>> result = new List<IList<int>>();

        result.Add(new List<int>());
        foreach (int num in nums) {
            List<IList<int>> newResult = new List<IList<int>>();
            foreach (IList<int> prev in result) {
                List<int> newSet = new List<int>(prev);
                newSet.Add(num);
                newResult.Add(newSet);
            }
            result.AddRange(newResult);
        }

        return result;
    }
}