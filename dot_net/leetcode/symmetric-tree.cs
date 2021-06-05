// https://leetcode.com/problems/symmetric-tree/

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
    public bool IsSymmetric(TreeNode root) {
        
       return recurSym(root.left,root.right);      
        
    }
    
    public bool recurSym(TreeNode lef,TreeNode rig ) {
        
        if(lef ==null && rig == null)
            return true;
        
        if(lef ==null || rig == null)
            return false;
        
        if(lef.val == rig.val)        
            return (recurSym(lef.left,rig.right) && recurSym(lef.right,rig.left));
        else
            return false;
        
    }
}
