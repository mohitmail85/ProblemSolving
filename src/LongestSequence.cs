using System.Collections.Generic;

public static class LongestSequence {

	 public static int solveLongestSequence(List<int> A) {
       /* 
            first create a HashSet with all values of array
            than iterate HashSet
            check if HashSet contains value A[i]-1, than continue the loop for next execution
            else check each consecutive element in HashSet and increase the answer count in while loop
        */
        
       HashSet<int> set = new HashSet<int>();
       int ans = -1;
       foreach (var item in A)
       {
        set.Add(item);
       }

       for(int i=0;i<set.Count;i++)
       {
            if(set.Contains(A[i] -1))
            {
                continue;
            }
            int x = A[i];
            int temp_ans = 0;

            while(set.Contains(x))
            {
                temp_ans++;
                x++;
            }
            ans = Math.Max(ans, temp_ans);

       }
       return ans;
    }
};

