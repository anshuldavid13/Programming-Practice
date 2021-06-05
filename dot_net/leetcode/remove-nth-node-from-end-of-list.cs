// https://leetcode.com/problems/remove-nth-node-from-end-of-list/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    ListNode head;
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        this.head=head;
        if(head == null)
            return null;
        
        if(head.next == null)
        {  this.head=null;
         return null; }
        
       int k= RemoveNthRecur(this.head,head,n);
        return this.head;
    }
    
    
     public int RemoveNthRecur(ListNode head, ListNode node, int n) {
        if(node == null)
        {
           return 0;
        }
         
        int y=RemoveNthRecur(head,node.next,n);
        if(y== n)
        {
            Console.WriteLine(" turn="+node.val);
            node.next = node.next.next;            
        }
         else if(y == n-1 && node==head)
         {
             Console.WriteLine(head.val+" head="+node.val);
             this.head = node.next;
              Console.WriteLine(head.val+" head="+node.val);
         }
         
         return 1+y;
    }
    
}
