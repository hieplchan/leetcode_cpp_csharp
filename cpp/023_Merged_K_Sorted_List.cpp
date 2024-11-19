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
    ListNode* mergeKLists(vector<ListNode*>& lists) {
        priority_queue<pair<int, ListNode*>, vector<pair<int, ListNode*>>, greater<pair<int, ListNode*>>> q;
        ListNode *head = new ListNode(), *curr = head;

        // first add minimum element of all list
        for (ListNode* node : lists)
            if (node) q.push({node->val, node});

        // loop until final node
        while (!q.empty()) {
            curr->next = q.top().second;
            curr = curr->next;
            q.pop();
            
            if (curr->next) {
                // add next node of the same list
                q.push({curr->next->val, curr->next});
            }
        }

        return head->next;
    }
};