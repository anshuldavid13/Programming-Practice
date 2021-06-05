// https://leetcode.com/problems/min-stack/

public class MinStack {

    /** initialize your data structure here. */
    
  List<int> list;
        /** initialize your data structure here. */
       
        public MinStack()
        {
            list = new List<int>();
        }
        // always add at the end  -- basics of list  
        public void Push(int x)
        {
            list.Add(x);
        }
        // remove from end to get the complexity to O(1)
        // Complexity of remove O(n - position) ==> n is number of elements 
        public void Pop()
        {
            list.RemoveAt(list.Count - 1);
        }
        // last added element will be always at last position 
        public int Top()
        {
            return list[list.Count - 1];
        }
        // default function of list 
        public int GetMin()
        {
            return list.Min();
        }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
