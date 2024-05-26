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
    public int MaxDepth(TreeNode root) {
        if (root == null)
        {
            // If the tree is empty, the depth is 0.
            return 0;
        }
        else {
            // Recursively find the depth of the left and right subtrees
            int leftDepth = MaxDepth(root.left);
            int rightDepth = MaxDepth(root.right);

            // The depth of the tree is the max of the depth of the subtrees, plus one for the root.
            return Math.Max(leftDepth, rightDepth) + 1;
        }
    }
}