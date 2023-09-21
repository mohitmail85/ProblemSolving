
/* 
Given a binary tree A, invert the binary tree and return it.
Inverting refers to making the left child the right child and vice versa.
*/

public static class BinaryTreeInvert
{

    public static TreeNode InvertBinaryTreeInvert(TreeNode A)
    {
        if (A == null)
        {
            return null;
        }

        TreeNode temp = A.right;
        A.right = A.left;
        A.left = temp;
        InvertBinaryTreeInvert(A.right);
        InvertBinaryTreeInvert(A.left);
        return A;

    }
}