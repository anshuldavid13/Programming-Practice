// https://leetcode.com/problems/add-two-numbers/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
class Solution {
    public ListNode addTwoNumbers(ListNode l1, ListNode l2) {
        
        if(l1== null && l2==null)
            return null;
        
        if(l1== null)
            return l2;
        
        if(l2== null)
            return l1;
        
        
        ListNode outL=null;
        ListNode head=null,temp;
        int rem=0,sum;
        
        while(l1 !=null && l2 !=null)
        {
            sum = l1.val + l2.val+rem;
            temp = new ListNode(sum%10);
            
            if(head == null)
            {
                head = temp;
                outL=temp;
            }
            else
            {
                outL.next = temp;
                outL=outL.next;
            }
                        
            rem= sum/10;
            l1=l1.next;
            l2=l2.next;        
        }
          
        while(l1 !=null)
        {
            sum= l1.val+rem;
            temp = new ListNode(sum%10);  
            rem= sum/10;
            if(head == null)
            {
                head = temp;
                outL=temp;
            }
            else
            {
                outL.next = temp;
                outL=outL.next;
            }
                    l1=l1.next;
        }
    
        while(l2 !=null)
        {
            sum= l2.val+rem;
            temp = new ListNode(sum%10);  
            rem= sum/10;       
            if(head == null)
            {
                head = temp;
                outL=temp;
            }
            else
            {
                outL.next = temp;
                outL=outL.next;
            }
                    l2=l2.next;
        }
        
        if(rem!=0)
        {
            temp = new ListNode(rem); 
            outL.next = temp;
        }
                              
             return head;
        
        
    }
    
    
    
}
