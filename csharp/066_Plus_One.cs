public class Solution {
    public int[] PlusOne(int[] digits) {
        for (int i = digits.Length - 1; i >= 0; i--) {
            digits[i] += 1;
            if (digits[i] != 10) break;

            digits[i] = 0;
            if (i == 0) {
                int[] newArr = new int[digits.Length + 1];
                newArr[0] = 1;
                digits.CopyTo(newArr, 1);
                return newArr;
            }
        }

        return digits;
    }
}