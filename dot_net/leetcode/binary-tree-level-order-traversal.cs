// https://leetcode.com/problems/binary-tree-level-order-traversal/

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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        
         List<IList<int>> fin = new List<IList<int>>();
        
        if(root==null)
            return fin;
        
        Queue<TreeNode> q= new Queue<TreeNode>();
        q.Enqueue(root);

        while(q.Count > 0)
        {
            var size = q.Count;
             IList<int> temp = new List<int>();
            
             for (int s = 0; s < size; s++) {
                var cur = q.Dequeue();
                temp.Add(cur.val);

                if (cur.left != null) {
                    q.Enqueue(cur.left);
                }

                if (cur.right != null) {
                    q.Enqueue(cur.right);
                }
            }
           fin.Add(temp);
            
        }
        return fin;
    }
}
