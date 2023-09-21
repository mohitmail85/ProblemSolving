public class AddOneToNumber
{
    public List<int> plusOne(List<int> A) {

           while (A.Count > 0 && A[0] == 0)
    {
        A.RemoveAt(0);
    }
    
    // If the array is empty, it means it only had leading zeroes, so the result is [1]
    if (A.Count == 0)
    {
        A.Add(1);
        return A;
    }

        for(int i=A.Count-1;i>=0;i--)
        {
           

            if(A[i] < 9)
            {
                A[i]++;
                break;
            }
            else
            {
                A[i] = 0;
                if(i == 0)
                {
                    A.Insert(0,1);
                    break;
                }
            }
            
            
        }
        return A;
        
    }
}