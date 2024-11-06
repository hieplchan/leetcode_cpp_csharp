// DFS
public class Solution {
    Dictionary<Node, Node> m = new Dictionary<Node, Node>();

    public Node CloneGraph(Node node) {
        if (node == null) return null;

        if (!m.ContainsKey(node)) {
            m[node] = new Node(node.val);
            foreach (Node neighbor in node.neighbors) {
                m[node].neighbors.Add(CloneGraph(neighbor));
            }
        }

        return m[node];
    }
}

// BFS
public class Solution {
    public Node CloneGraph(Node node) {
        if (node == null) return null;

        Dictionary<Node, Node> m = new Dictionary<Node, Node>();
        Queue<Node> q = new Queue<Node>();

        Node root = new Node(node.val);
        m.Add(node, root);
        q.Enqueue(node);

        while (q.Count > 0) {
            Node curr = q.Dequeue();

            foreach (Node neighbor in curr.neighbors) {
                // node not existed
                if (!m.ContainsKey(neighbor)) {
                    Node clone = new Node(neighbor.val);
                    m.Add(neighbor, clone);
                    q.Enqueue(neighbor);
                }

                m[curr].neighbors.Add(m[neighbor]);
            }
        }

        return root;
    }
}