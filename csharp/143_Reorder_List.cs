/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public void ReorderList(ListNode head) {
        if (head == null) return;

        // find middle node
        ListNode slow = head, fast= head;
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }

        // reverse second half
        ListNode prev = slow, curr = slow.next;
        slow.next = null;
        while (curr != null) {
            ListNode next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        // merge 2 list
        ListNode h1 = head, h2 = prev;
        while (h1 != h2) {
            ListNode temp = h1.next;
            h1.next = h2;
            h1 = h1.next;
            h2 = temp;
        }
    }
}