// https://leetcode.com/problems/copy-list-with-random-pointer/

/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
        
        if(head==null)
            return null;
        
        Node newHead = new Node(head.val);
        
        Node newN= newHead;
        Node newO= head;
        
        while(newO.next != null)
        {  
            Node tempN = new Node(newO.next.val);
            newN.next=tempN;
            newN=newN.next;
            newO=newO.next;
        }
        
        Node newN1= newHead;
        Node newO1= head;
        
         while(newO1 != null)
        {  
             if(newO1.random == null)
             {
                 Console.WriteLine("ins newO1.val="+newO1.val+" newN1.val="+newN1.val);
                 newN1.random = null;
                 newN1=newN1.next;
                 newO1=newO1.next;
                 continue;
             }
             
            Node N1= newHead;
            Node O1= head;  
            while(newO1.random != O1)
            {  
                O1 = O1.next;
                N1 = N1.next;
            } 
            
             newN1.random = N1;
             
            newN1=newN1.next;
            newO1=newO1.next;
             
        }
        
        
        
        return newHead;
        
    }
}
