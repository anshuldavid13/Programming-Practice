// https://leetcode.com/problems/merge-two-sorted-lists/

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
    public ListNode mergeTwoLists(ListNode l1, ListNode l2) {
        
        ListNode pt=null;
        ListNode head=null;
        
        while(l1 !=null && l2 !=null)
        {
            if(l1.val > l2.val)
            { 
                if(pt==null)
                {                    
                    head = new ListNode(l2.val);
                    pt=head; 
                }
                 else
                {
                  pt.next= l2;  
                    pt = pt.next;
                }             
                l2= l2.next;
            }
            else 
            {
                 if(pt==null)
                {                    
                    head = new ListNode(l1.val);
                    pt=head; 
                }
                else
                {
                   pt.next= l1;  
                    pt = pt.next;                      
                }
                l1 = l1.next;
            }
        }
        
        while(l1 !=null)
        {
            if(pt==null)
                {                    
                    head = new ListNode(l1.val);
                    pt=head; 
                } 
            else
                {
                     pt.next= l1;  
                    pt = pt.next;   
                }               
                l1 = l1.next;
        }
        
        while(l2 !=null)
            { 
                if(pt==null)
                {                    
                    head = new ListNode(l2.val);
                    pt=head; 
                }
                 else
                {
                     pt.next= l2;     
                    pt = pt.next;
                }              
                l2= l2.next;
            }
        
        return head;
    }
}
