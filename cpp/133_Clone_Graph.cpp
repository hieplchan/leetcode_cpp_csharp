// DFS
class Solution {
private:
    unordered_map<Node*, Node*> m;
public:
    Node* cloneGraph(Node* node) {
        if (node == nullptr) return nullptr;
        
        if (m.count(node) == 0) {
            m[node] = new Node(node->val);
            for (auto x : node->neighbors) {
                m[node]->neighbors.push_back(cloneGraph(x));
            }
        }

        return m[node];
    }
};

// BFS
class Solution {
public:
    Node* cloneGraph(Node* node) {
        if (node == nullptr) return nullptr;
        
        unordered_map<Node*, Node*> m;
        queue<Node*> q;

        Node *root = new Node(node->val);
        m[node] = root;
        q.push(node);

        while (!q.empty()) {
            Node *curr = q.front();
            q.pop();
            
            for (auto neighbor : curr->neighbors) {
                // node not existed
                if (m.count(neighbor) == 0) {
                    Node *clone = new Node(neighbor->val);
                    m[neighbor] = clone;
                    q.push(neighbor);
                }

                m[curr]->neighbors.push_back(m[neighbor]);
            }
        }

        return root;
    }
};