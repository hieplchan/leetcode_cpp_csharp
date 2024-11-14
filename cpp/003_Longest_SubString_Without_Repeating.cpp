class Solution {
public:
    int lengthOfLongestSubstring(string s) {
        unordered_map<char, int> m;
        int maxLength = 0;

        for (int left = 0, right = 0; right < s.size(); right++) {
            m[s[right]]++; // add char to hash: 1 = not repeated

            // If repeated char, move left to right
            // and remove character until repeated 
            // is not part of the window
            while (m[s[right]] > 1) m[s[left++]]--;

            maxLength = max(maxLength, right - left + 1);
        }

        return maxLength;
    }
};