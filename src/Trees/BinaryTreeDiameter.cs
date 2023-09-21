
/* 
Given a Binary Tree A consisting of N integer nodes, you need to find the diameter of the tree.
The diameter of a tree is the number of edges on the longest path between two nodes in the tree.
*/

public static class BinaryTreeDiameter
{
    static int diameter;
    public static int GetBinaryTreeDiameter(TreeNode A)
    {
        diameter = 0;
        TreeHeight(A);
        return diameter;

    }

    public static int TreeHeight(TreeNode A)
    {
        if (A == null) return -1;
        int leftHeight = TreeHeight(A.left);
        int rightHeight = TreeHeight(A.right);
        diameter = Math.Max(diameter, leftHeight + rightHeight + 2);
        int height = Math.Max(leftHeight, rightHeight) + 1;
        return height;

    }
}