public class ZeroQueryTwo {
    public List<int> SolveZeroQueryMethod(int A, List<List<int>> B) {
        List<int> res = new List<int>(A);
        for(int j=0;j<A;j++){
            res.Add(0);
        }
        for(int i=0;i<B.Count;i++)
        {
            int s = B[i][0] -1;
            int e = B[i][1] -1;
            int val = B[i][2];

            res[s] = res[s] + val;
            if(e < A-1)
            {
               res[e+1] = res[e+1] + (-val); 
            }
        }

        for(int i=1;i<A;i++){
            res[i]= res[i]+res[i-1];
        }
        return res;
    }
}
