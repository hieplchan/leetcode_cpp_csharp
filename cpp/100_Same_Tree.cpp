// BFS
class Solution {
public:
    bool isSameTree(TreeNode* t1, TreeNode* t2) {
        if (!t1 && !t2) return true;
        if (!t1 || !t2) return false;

        queue<TreeNode*> q1, q2;
        q1.push(t1);
        q2.push(t2);

        while(!q1.empty() && !q2.empty()) {
            TreeNode *n1 = q1.front(), *n2 = q2.front();
            q1.pop();
            q2.pop();

            if (!n1 || !n2) {
                if (!n1 && !n2) {
                    continue;
                } else {
                    return false;
                }
            }
            
            if (n1->val != n2->val) return false;

            q1.push(n1->left);
            q1.push(n1->right);
            q2.push(n2->left);
            q2.push(n2->right);
        }

        return q1.size() == q2.size();
    }
};

// DFS
class Solution {
public:
    bool isSameTree(TreeNode* t1, TreeNode* t2) {
        if (!t1 && !t2) return true;
        if (!t1 || !t2) return false;

        stack<TreeNode*> s1, s2;
        s1.push(t1);
        s2.push(t2);

        while (!s1.empty() && !s2.empty()) {
            TreeNode *n1 = s1.top(), *n2 = s2.top();
            s1.pop();
            s2.pop();

            if (!n1 || !n2) {
                if (!n1 && !n2) {
                    continue;
                } else {
                    return false;
                }
            }

            if (n1->val != n2->val) return false;

            s1.push(n1->left);
            s1.push(n1->right);
            s2.push(n2->left);
            s2.push(n2->right);
        }

        return s1.empty() && s2.empty();
    }
};