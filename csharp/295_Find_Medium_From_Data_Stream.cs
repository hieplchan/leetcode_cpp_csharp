public class MedianFinder {
    PriorityQueue<int, int> leftQueue;
    PriorityQueue<int, int> rightQueue;

    public MedianFinder() {
        leftQueue = new PriorityQueue<int, int>(); // max heap
        rightQueue = new PriorityQueue<int, int>(); // min heap
    }
    
    public void AddNum(int num) {
        rightQueue.Enqueue(num, num);

        // remove minimum from rightQueue
        int val = rightQueue.Dequeue();
        leftQueue.Enqueue(val, -val);

        // re-balance
        if (leftQueue.Count - rightQueue.Count > 1) {
            val = leftQueue.Dequeue();
            rightQueue.Enqueue(val, val);
        }
    }
    
    public double FindMedian() {
        return leftQueue.Count > rightQueue.Count ? leftQueue.Peek() : (leftQueue.Peek() + rightQueue.Peek()) / 2.0;
    }
}

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */