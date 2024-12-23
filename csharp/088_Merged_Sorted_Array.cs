public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int p1 = m - 1, p2 = n - 1, right = m + n - 1;
        while (right >= 0) {
            if (p1 < 0) {
                nums1[right] = nums2[p2--];
            } else if (p2 < 0) {
                nums1[right] = nums1[p1--];
            } else {
                nums1[right] = nums1[p1] > nums2[p2] ? nums1[p1--] : nums2[p2--];
            }
            right--;
        }
    }
}