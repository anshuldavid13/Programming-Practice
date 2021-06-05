// https://leetcode.com/problems/implement-queue-using-stacks/

public class MyQueue {

    Stack<int> stack = new Stack<int>();
    
    /** Initialize your data structure here. */
    public MyQueue() {
        int x;
    }
    
    /** Push element x to the back of queue. */
    public void Push(int x) {
        stack.Push(x);        
    }
    
    /** Removes the element from in front of queue and returns that element. */
    public int Pop() {
        Stack<int> newStack = new Stack<int>();
        
        while(stack.Count >0)
            newStack.Push(stack.Pop());
        
        int v = newStack.Pop();
        
        while(newStack.Count >0)
            stack.Push(newStack.Pop());
        
        return v;
    }
    
    /** Get the front element. */
    public int Peek() {
        Stack<int> newStack = new Stack<int>();
        
        while(stack.Count >0)
            newStack.Push(stack.Pop());
        
        int v = newStack.Peek();
        
        while(newStack.Count >0)
            stack.Push(newStack.Pop());
        
        return v;
    }
    
    /** Returns whether the queue is empty. */
    public bool Empty() {
        if(stack.Count == 0)
            return true;
            else return false;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */
