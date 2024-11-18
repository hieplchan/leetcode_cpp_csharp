// BFS
public class Solution {
    public bool IsSameTree(TreeNode t1, TreeNode t2) {
        if (t1 == null & t2 == null) return true;
        if (t1 == null || t2 == null) return false;

        Queue<TreeNode> q1 = new Queue<TreeNode>();
        Queue<TreeNode> q2 = new Queue<TreeNode>();
        q1.Enqueue(t1);
        q2.Enqueue(t2);

        while (q1.Count() != 0 && q2.Count() != 0) {
            TreeNode n1 = q1.Dequeue(), n2 = q2.Dequeue();

            if (n1 == null || n2 == null) {
                if (n1 == null && n2 == null)
                    continue;
                else
                    return false;
            }

            if (n1.val != n2.val) return false;

            q1.Enqueue(n1.left);
            q1.Enqueue(n1.right);
            q2.Enqueue(n2.left);
            q2.Enqueue(n2.right);
        }

        return q1.Count() == q2.Count();
    }
}

// DFS
public class Solution {
    public bool IsSameTree(TreeNode t1, TreeNode t2) {
        if (t1 == null & t2 == null) return true;
        if (t1 == null || t2 == null) return false;

        Stack<TreeNode> s1 = new Stack<TreeNode>();
        Stack<TreeNode> s2 = new Stack<TreeNode>();
        s1.Push(t1);
        s2.Push(t2);

        while (s1.Count() != 0 && s2.Count() != 0) {
            TreeNode n1 = s1.Pop(), n2 = s2.Pop();

            if (n1 == null || n2 == null) {
                if (n1 == null && n2 == null)
                    continue;
                else
                    return false;
            }

            if (n1.val != n2.val) return false;

            s1.Push(n1.left);
            s1.Push(n1.right);
            s2.Push(n2.left);
            s2.Push(n2.right);
        }

        return s1.Count() == s2.Count();
    }
}