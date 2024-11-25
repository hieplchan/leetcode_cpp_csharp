class Solution {
public:
    vector<int> plusOne(vector<int>& digits) {
        for (int i = digits.size() - 1; i >= 0; i--) {
            digits[i] += 1;
            if (digits[i] == 10) {
                if (i == 0) {
                    digits[i] = 0;
                    digits.insert(digits.begin(), 1);
                } else {
                    digits[i] = 0;
                }
            } else {
                break;
            }
        }

        return digits;
    }
};