
using System.Text;
using Newtonsoft.Json;
using System.Collections;

public class Program
{
    public static void Main()
    {

        // TreeNode A = new TreeNode(1);
        // A.left = new TreeNode(2);
        // A.right = new TreeNode(3);
        // A.left.left = new TreeNode(4);
        // A.left.right = new TreeNode(5);
        // var res = BinaryTreeDiameter.GetBinaryTreeDiameter(A);
        // SolutionTrie solution = new SolutionTrie();
        // string input1 = "abadbc";
        // string input2 = "abcabc";
        // Console.WriteLine("Input 1: " + solution.solve(input1)); // Output 1: "aabbdd"
        // Console.WriteLine("Input 2: " + solution.solve(input2)); // Output 2: "aaabc#"
        List<int> A = new List<int> { 1, 2, 3 };
        BacktrackingSubset obj = new BacktrackingSubset();
        var temp = obj.SolveSubset(A);
    }

}
