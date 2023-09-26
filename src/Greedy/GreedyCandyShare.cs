using System.Collections.Generic;

public class GreedyCandyShare
{
    public int DistributeCandy(List<int> A)
    {
        List<int> CL = new List<int>();
        List<int> CR = new List<int>();
        int count = 0;
        CL.Add(1);
        for (int i = 0; i < A.Count; i++)
        {
            CR.Add(1);
        }

        for (int i = 0; i < A.Count - 1; i++)
        {
            if (A[i] < A[i + 1])
            {
                if (CL.Any())
                {
                    CL.Add(CL[i] + 1);

                }
                else
                {
                    CL.Add(1);
                }


            }
            else
            {
                CL.Add(1);
            }
        }

        for (int i = A.Count - 1; i > 0; i--)
        {
            if (A[i] < A[i - 1])
            {
                CR[i - 1] = CR[i] + 1;
            }
        }

        for (int i = 0; i < A.Count; i++)
        {
            int temp = Math.Max(CL[i], CR[i]);
            count = count + temp;
        }

        return count;

    }

};
