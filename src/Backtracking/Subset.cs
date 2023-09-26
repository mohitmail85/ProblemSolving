using System.Collections.Generic;

public class BacktrackingSubset
{
    List<List<int>> ans = new List<List<int>>();
    void solve(int idx, List<int> cur, List<int> A)
    {
        if (idx == A.Count)
        {
            List<int> temp = new List<int>();
            foreach (int x in cur)
            {
                temp.Add(x);
            }
            ans.Add(temp);
            return;
        }
        solve(idx + 1, cur, A);
        int element = A[idx];
        cur.Add(element);
        solve(idx + 1, cur, A);
        cur.RemoveAt(cur.Count - 1);
    }

    public List<List<int>> SolveSubset(List<int> A)
    {
        A.Sort();
        List<int> cur = new List<int>();
        solve(0, cur, A);
        ans.Sort((List<int> a, List<int> b) =>
        {
            for (int i = 0; i < Math.Min(a.Count, b.Count); i++)
            {
                if (a[i] != b[i])
                {
                    return a[i].CompareTo(b[i]);
                }
            }
            return a.Count.CompareTo(b.Count);
        });
        return ans;

    }

};
