public class RussianDollEnvelopes
{

    public int GetLIS(List<int> A)
    {
        int n = A.Count;
        int ans = 0;
        int[] dp = new int[n];
        dp[0] = 1;

        for (int i = 1; i < n; i++)
        {
            int t_Max = 0;
            for (int j = 0; j < i; j++)
            {
                if (A[j] < A[i])
                {
                    t_Max = Math.Max(t_Max, dp[j]);
                }
            }
            dp[i] = t_Max + 1;
            ans = Math.Max(ans, dp[i]);
        }
        return 0;
    }

}