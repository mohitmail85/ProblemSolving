class FirstMissingNumber {
    
    public int FindMissingNumber(List<int> A)
    {
        A.Sort();
        int val = 1;
         for(int i=0;i<A.Count;i++)
        {
            if(A[i] <=0 )
            {
                continue;
            }

            else
            {
                if(A[i] == val -1 )
                {
                    continue;
                }
                else if(A[i] == val)
                {
                    val++;
                }
                else{
                    return val;
                }
            }
        }

        return val;

    }
    
}

