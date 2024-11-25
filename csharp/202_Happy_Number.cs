public class Solution {
    HashSet<int> checkedSum = new HashSet<int>();
    public bool IsHappy(int n) {
        if (n == 1) return true;

        int sum = 0;
        while (n > 0) {
            sum += (int)Math.Pow(n % 10, 2);
            n /= 10;
        }

        if (checkedSum.Contains(sum)) {
            return false;
        } else {
            checkedSum.Add(sum);
            return IsHappy(sum);
        }
    }
}