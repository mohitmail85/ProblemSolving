public class Permutations
{
    bool[] marked;
    List<List<int>> res;

    public void Rec(int idx, List<int> temp, List<int> A)
    {
        int n = A.Count;
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

        for (int i = 0; i < n; i++)
        {
            if (!marked[i])
            {
                marked[i] = true;
                temp.Add(A[i]);
                Rec(idx + 1, temp, A);
                marked[i] = false;
                temp.RemoveAt(temp.Count - 1);

            }
        }
    }

    public List<List<int>> Permute(List<int> A)
    {
        marked = new bool[A.Count];
        res = new List<List<int>>();
        Rec(0, new List<int>(), A);
        return res;

    }
}