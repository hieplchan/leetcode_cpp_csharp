public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> m = new Dictionary<char, int>();
        int maxLength = 0;

        for (int left = 0, right = 0; right < s.Length; right++) {
            if (!m.ContainsKey(s[right])){
                m.Add(s[right], 1);
            } else {
                m[s[right]]++;
            }
            
            while (m[s[right]] > 1) m[s[left++]]--;
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}