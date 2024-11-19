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
    public ListNode MergeKLists(ListNode[] lists) {
        ListNode head = new ListNode(), curr = head;
        List<KeyValuePair<int, ListNode>> m = new List<KeyValuePair<int, ListNode>>();

        // add all node to map
        foreach (ListNode listHead in lists) {
            curr = listHead;
            while (curr != null) {
                m.Add(new KeyValuePair<int, ListNode>(curr.val, curr));
                curr = curr.next;
            }
        }

        // sorted map
        m.Sort(delegate(KeyValuePair<int, ListNode> x, KeyValuePair<int, ListNode> y) {
            return x.Key.CompareTo(y.Key);
        });

        // link result list
        curr = head;
        foreach(KeyValuePair<int, ListNode> node in m) {
            curr.next = node.Value;
            curr = curr.next;
            curr.next = null;
        }

        return head.next;
    }
}