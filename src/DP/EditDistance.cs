public class EditDistance
{
    int[,] dp;
    public int minDistance(string A, string B)
    {
        int n = A.Length;
        int m = B.Length;
        dp = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                dp[i, j] = -1;
            }
        }
        return editDistanceCal(A, B, n - 1, m - 1);
    }

    public int editDistanceCal(string A, string B, int i, int j)
    {
        if (i < 0) return j + 1;
        if (j < 0) return i + 1; ;
        if (dp[i, j] != -1)
        {
            return dp[i, j];
        }
        int ans = 0;
        if (A[i] == B[j])
        {
            ans = editDistanceCal(A, B, i - 1, j - 1);
        }
        else
        {
            int a = editDistanceCal(A, B, i, j - 1);
            int b = editDistanceCal(A, B, i - 1, j - 1);
            int c = editDistanceCal(A, B, i - 1, j);
            ans = Math.Min(a, Math.Min(b, c)) + 1;

        }
        dp[i, j] = ans;
        return ans;

    }

}