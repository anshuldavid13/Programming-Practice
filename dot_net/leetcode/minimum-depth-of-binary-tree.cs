// https://leetcode.com/problems/minimum-depth-of-binary-tree/

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
    
    public int MinDepth(TreeNode root) {
        if(root == null)
            return 0;
        
        return recur(root);
    }
    
    public int recur(TreeNode node) {
        
        if(node == null)
            return 0;    
        
        if(node.left == null && node.right == null)
            return 1;    
        
        if(node.right == null)
             return 1+recur(node.left);
        if(node.left == null)     
            return 1+recur(node.right);
        
       return Math.Min(recur(node.left),recur(node.right))+1;
    }
}
