// https://leetcode.com/problems/average-of-levels-in-binary-tree/

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
    public IList<double> AverageOfLevels(TreeNode root) {
        
        var avgs = new List<double>();
        var q = new Queue<TreeNode>();  
        q.Enqueue(root);
        
        while(q.Count >0)
        {
            int size = q.Count;
            double sum = 0.0;
            for(int i=0;i<size;i++)
            {
                TreeNode n = q.Dequeue();
                sum = sum + n.val;
                
                if(n.left!=null)
                    q.Enqueue(n.left);
                
                if(n.right!=null)
                    q.Enqueue(n.right);
            }
            avgs.Add(sum/size);
        }
        return avgs;
    }
}
