public class RecentCounter {
    Queue<int> q = new Queue<int>();

    public RecentCounter() {
        q.Clear();
    }
    
    public int Ping(int t) {
        if(q.Count == 0)
        {
            q.Enqueue(t);
            return q.Count;
        }
        
        while(q.Count >0 && q.Peek() < (t-3000))
        {
            q.Dequeue();            
        }
        q.Enqueue(t);
        return q.Count;
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */
