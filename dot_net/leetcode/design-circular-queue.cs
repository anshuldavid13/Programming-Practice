// https://leetcode.com/problems/design-circular-queue/

public class MyCircularQueue {
    List<int> list;
    int capacity;

    public MyCircularQueue(int k) {
        capacity = k;
        list = new List<int>();
    }
    
    public bool EnQueue(int value) {
        if(list.Count < capacity)
        { list.Add(value);
            return true;}
        else
            return false;
    }
    
    public bool DeQueue() {
       if(list.Count >0)
       { list.RemoveAt(0); 
       return true;}
        else
            return false;
    }
    
    public int Front() {
        if(list.Count >0)
            return list[0];
        else
            return -1;
    }
    
    public int Rear() {
        if(list.Count >0)
             return list[list.Count-1];
        else
            return -1;
    }
    
    public bool IsEmpty() {
        if(list.Count == 0)
            return true;
        else
            return false;
    }
    
    public bool IsFull() {
        if(list.Count == capacity)
            return true;
        else
            return false;
    }
}

/**
 * Your MyCircularQueue object will be instantiated and called as such:
 * MyCircularQueue obj = new MyCircularQueue(k);
 * bool param_1 = obj.EnQueue(value);
 * bool param_2 = obj.DeQueue();
 * int param_3 = obj.Front();
 * int param_4 = obj.Rear();
 * bool param_5 = obj.IsEmpty();
 * bool param_6 = obj.IsFull();
 */
