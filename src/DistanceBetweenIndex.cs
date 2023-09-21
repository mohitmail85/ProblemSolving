public class DistanceBetweenIndex {

	 public int solveDistanceBetweenIndex(List<int> A) {
       
       Dictionary<int,int>  map = new Dictionary<int,int>();
        int res = Int32.MaxValue;
        for(int i=0;i<A.Count();i++)
        {
            map[A[i]] = -1;
        }

        for(int i=0;i<A.Count;i++)
        {
            if(map[A[i]] !=-1){
                res = Math.Min(res, i - map[A[i]]);
            }
            map[A[i]] = i;
        }
        return res;
    }
};

