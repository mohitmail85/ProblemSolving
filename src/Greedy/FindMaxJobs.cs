class pair
{
    public int S, E;
    public pair(int s, int e)
    {
        S = s;
        E = e;
    }
}

class GFG : IComparer<pair>
{
    public int Compare(pair x, pair y)
    {
        int i = x.S.CompareTo(y.S);
        if (i == 0)
            i = x.E.CompareTo(y.E);
        return i;
    }
}
public class FindMaxJobs
{
    public int FindJobs(List<int> A, List<int> B)
    {
        int n = A.Count;
        List<pair> a = new List<pair>();
        for (int i = 0; i < n; i++)
        {
            a.Add(new pair(A[i], B[i]));
        }
        GFG gg = new GFG();
        a.Sort(gg);
        int end = 0, ans = 0;
        foreach (pair job in a)
        {
            if (job.S >= end)
            {
                ans++;
                end = job.E;
            }
        }
        return ans;
    }

}