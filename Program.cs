
using System.Text;
using Newtonsoft.Json;
using System.Collections;

public class Program
{
    public static void Main()
    {

        TreeNode A = new TreeNode(1);
        A.left = new TreeNode(2);
        A.right = new TreeNode(3);
        A.left.left = new TreeNode(4);
        A.left.right = new TreeNode(5);
        var res = BinaryTreeDiameter.GetBinaryTreeDiameter(A);

    }

}