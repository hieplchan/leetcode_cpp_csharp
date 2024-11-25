public class Solution {
    public string ReverseWords(string s) {
        string result = "";
        
        var words = s.Trim().Split(' ');
        foreach (var word in words) {
            if (string.IsNullOrEmpty(word)) continue;
            result = word + " " + result;
        }

        return result.Trim();
    }
}