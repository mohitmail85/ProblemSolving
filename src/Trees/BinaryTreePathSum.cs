
/* 
Given a binary tree and a sum, determine if the tree has a root-to-leaf path such that adding up all the values along the path equals the given sum.
*/

public static class BinaryTreePathSum
{

    public static int HasBinaryTreePathSum(TreeNode A, int B)
    {
        if (A == null) return 0;
        if (A.left == null && A.right == null) return A.val == B ? 1 : 0;
        int l = HasBinaryTreePathSum(A.left, B - A.val);
        int r = HasBinaryTreePathSum(A.right, B - A.val);
        if (l == 1 || r == 1) return 1;
        else return 0;

    }
}