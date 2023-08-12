public class PalindromRec {
		
		public bool isPalin(string A, int s, int e){
			if(s>e)
			{
				return true;
			}
			if(isPalin(A, s+1, e-1) && A[s] == A[e])
			{
				return true;
			}
			return false;
		}
};
