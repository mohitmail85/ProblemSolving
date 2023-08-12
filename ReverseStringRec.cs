public class ReverseStringRec {
		
		public void reverse(string A, int s, int e){
			if(e == 0)
            {
                Console.WriteLine(A[s]);
                return;
            }
            else{
                reverse(A, s+1, e-1);
                Console.WriteLine(A[s]);
                return;
            }

		}
};
