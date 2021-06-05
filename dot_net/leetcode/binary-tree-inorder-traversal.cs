// https://leetcode.com/problems/binary-tree-inorder-traversal/

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
    List<int> or = new List<int>();
    
    public IList<int> InorderTraversal(TreeNode root) {
             
        recInor(root);
        return or;
    }
    
    public void recInor(TreeNode root)
    {
        if(root == null)
            return;
        
        recInor(root.left);
        or.Add(root.val);
        recInor(root.right);
        
    }
}
