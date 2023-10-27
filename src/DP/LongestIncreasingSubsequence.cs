/*
Problem Description
Find the longest increasing subsequence of a given array of integers, A.

In other words, find a subsequence of array in which the subsequence's elements are in strictly increasing order, and in which the subsequence is as long as possible.

In this case, return the length of the longest increasing subsequence.
TC - 0(n2)
 */
public class LongestIncreasingSubsequence
{
    public int lis(List<int> A)
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
        return ans;
    }

}