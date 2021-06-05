// https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    
    public TreeNode SortedArrayToBST(int[] nums) {
        
       
        if(nums.Length == 1)
        {
             TreeNode root = new TreeNode(nums[0]);
            return root;        
        }
        
        return recur(nums,0,nums.Length-1);
    }
        
        
         public TreeNode recur(int[] nums,int l,int r) 
         {
             if(l>r)
             {
                 return null;
             }
             
             int m = (l+r)/2;  
             TreeNode node= new TreeNode(nums[m]);
              node.left = recur(nums,l,m-1);
              node.right = recur(nums,m+1,r);
              return node;          
             
         }
        
    
}
