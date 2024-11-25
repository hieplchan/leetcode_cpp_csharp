class Solution {
    unordered_set<int> checkedSum;
public:
    bool isHappy(int n) {
        if (n == 1) return true;

        long sum = 0;
        while (n > 0) {
            sum += pow(n % 10, 2);
            n /= 10;
        }
        
        if (checkedSum.count(sum)) {
            return false;
        }
        else {
            checkedSum.insert(sum);
            return isHappy(sum);
        }
    }
};