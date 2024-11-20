class MedianFinder {
public:
    MedianFinder() {

    }
    
    void addNum(int num) {
        if (left.empty() || num <= left.top()) {
            left.push(num);
        } else {
            right.push(num);
        }

        // re-balance 2 queue
        if (left.size() > right.size() + 1) {
            right.push(left.top());
            left.pop();
        }
        if(right.size() > left.size()){
            left.push(right.top());
            right.pop();
        }
    }
    
    double findMedian() {
        return left.size() > right.size() ? left.top() : (left.top() + right.top()) / 2.0;
    }
private:
    priority_queue<int> left; // contains lower value
    priority_queue<int, vector<int>, greater<int>> right; // contains higher value
};

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder* obj = new MedianFinder();
 * obj->addNum(num);
 * double param_2 = obj->findMedian();
 */