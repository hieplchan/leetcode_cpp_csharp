class Solution {
public:
    string reverseWords(string s) {
        string result;
        vector<string> v;

        string temp;
        for (auto c : s) {
            if (c == ' ') {
                if (!temp.empty()) {
                    v.push_back(temp);
                    temp.clear();
                }
            } else {
                temp += c;
            }
        }

        if (!temp.empty())
            v.push_back(temp);

        for (int i = v.size() - 1; i >= 0; i--) {
            result += v[i];
            if (i != 0)
                result += ' ';
        }

        return result;
    }
};