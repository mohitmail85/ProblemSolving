
/* 
Given an array where elements are sorted in ascending order, convert it to a height Balanced Binary Search Tree (BBST).
Balanced tree : a height-balanced binary tree is defined as a binary tree in which the depth of the two subtrees of every node never differ by more than 1.
*/

public static class BinaryTreeBalancedSorted
{

    public static TreeNode GetSortedArrayToBST(List<int> A)
    {
        return BalancedTree(A, 0, A.Count - 1);

    }

    private static TreeNode BalancedTree(List<int> A, int start, int end)
    {
        if (start > end) return null;
        int mid = (start + end) / 2;
        TreeNode root = new TreeNode(A[mid]);
        root.left = BalancedTree(A, start, mid - 1);
        root.right = BalancedTree(A, mid + 1, end);
        return root;
    }
}