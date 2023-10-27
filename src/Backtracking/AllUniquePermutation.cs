
public class AllUniquePermutation
{
    bool[] marked;
    List<List<int>> res;
    List<int> A;
    int n;

    public List<List<int>> permute(List<int> A)
    {
        n = A.Count;
        marked = new bool[n];
        res = new List<List<int>>();
        this.A = A;
        rec(0, new List<int>());
        return res;

    }

    public void rec(int idx, List<int> temp)
    {
        if (idx == n)
        {
            List<int> curr = new List<int>();
            foreach (int x in temp)
            {
                curr.Add(x);
            }
            res.Add(curr);
            return;
        }

        Dictionary<int, int> repeat = new Dictionary<int, int>();
        for (int i = 0; i < n; i++)
        {
            if (!marked[i] && !repeat.ContainsKey(A[i]))
            {
                repeat.Add(A[i], 1);
                marked[i] = true;
                temp.Add(A[i]);
                rec(idx + 1, temp);
                marked[i] = false;
                temp.RemoveAt(temp.Count - 1);
            }
        }

    }

}
