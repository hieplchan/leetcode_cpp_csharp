/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */
class Solution {
public:
    void reorderList(ListNode* head) {
        if (!head) return;

        // find middle node, slow = middle node
        ListNode *slow = head, *fast = head;
        while (fast && fast->next) {
            slow = slow->next;
            fast = fast->next->next;
        }

        //reverse second half
        ListNode *prev = slow, *curr = slow->next;
        slow->next = nullptr;
        while (curr) {
            ListNode *next = curr->next;
            curr->next = prev;
            prev = curr;
            curr = next;
        }

        // merge 2 new list;
        ListNode *h1 = head, *h2 = prev;
        while (h1 != h2) {
            ListNode *temp = h1->next;
            h1->next = h2;
            h1 = h1->next;
            h2 = temp;
        }
    }
};