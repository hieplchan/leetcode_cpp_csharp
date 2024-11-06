/*
// Definition for a Node.
class Node {
public:
    int val;
    vector<Node*> neighbors;
    Node() {
        val = 0;
        neighbors = vector<Node*>();
    }
    Node(int _val) {
        val = _val;
        neighbors = vector<Node*>();
    }
    Node(int _val, vector<Node*> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
};
*/

class Solution {
public:
    Node* cloneGraph(Node* node) {
        if (node == nullptr) return nullptr;

        unordered_map<int, Node*> adj, visited;
        queue<Node*> q;

        // clone first node
        visitNode(adj, node, visited, q);

        // traverse all node
        while (!q.empty()) {
            visitNode(adj, q.front(), visited, q);
            q.pop();
        }

        // return adj.begin()->second;
        return adj[1];
    }

    void visitNode(unordered_map<int, Node*>& adj, Node* node, 
                    unordered_map<int, Node*>& visited, queue<Node*>& q) {        
        createNodeIfNeeded(adj, node->val);
        Node *temp = adj[node->val];

        // add adj node to this node
        for (Node* neighbor : node->neighbors) {
            createNodeIfNeeded(adj, neighbor->val);

            addNeighborToNode(temp, adj[neighbor->val]);

            // add node to queqe if not visited
            if (visited.find(neighbor->val) == visited.end())
                q.push(neighbor);
        }

        visited[temp->val] = temp;
    }

    void createNodeIfNeeded(unordered_map<int, Node*>& adj, int val) {
        if (adj.find(val) == adj.end()) {
            Node *temp = new Node(val);
            adj[val] = temp;
        }
    }

    void addNeighborToNode(Node* node, Node* addedNode) {
        // dont add if existed
        for (Node *temp : node->neighbors) {
            if (temp->val == addedNode-> val) return;
        }
        node->neighbors.push_back(addedNode);
    }
};