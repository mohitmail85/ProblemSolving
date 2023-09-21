
/* 
Given a binary tree,
Populate each next pointer to point to its next right node. If there is no next right node, the next pointer should be set to NULL.
Initially, all next pointers are set to NULL.
Assume perfect binary tree.
*/

public static class BinaryTreeNextPointer
{

    public static void ConnectBinaryTreeNextPointer(TreeLinkNode root)
    {
        Queue<TreeLinkNode> queue = new Queue<TreeLinkNode>();
        queue.Enqueue(root);
        queue.Enqueue(null);

        while (queue.Count > 1)
        {
            TreeLinkNode temp = queue.Peek();
            queue.Dequeue();

            if (temp == null)
            {
                queue.Enqueue(null);
            }
            else
            {
                if (temp.left != null)
                {
                    queue.Enqueue(temp.left);
                }
                if (temp.right != null)
                {
                    queue.Enqueue(temp.right);
                }
                temp.next = queue.Peek();
            }
        }


    }
}