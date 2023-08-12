// Problem Description
// You are given two strings, A and B, of size N and M, respectively.

// You have to find the count of all permutations of A present in B as a substring. You can assume a string will have only lowercase letters.
// ex: 
// Input
// A = "abc"
// B = "abcbacabc"
// output - 5
public static class CountRightTriangle {
     public static int solveRightTriangle(List < int > A, List < int > B) {
        int n = A.Count;
        // stores the frequency of each x coordinate
        Dictionary < int, int > mpx = new Dictionary < int, int > ();
        // stores the frequency of each y coordinate
        Dictionary < int, int > mpy = new Dictionary < int, int > ();
        for (int i = 0; i < n; i++) {
            if (!mpx.ContainsKey(A[i])) {
                mpx.Add(A[i], 1);
            } else
                mpx[A[i]]++;

            if (!mpy.ContainsKey(B[i])) {
                mpy.Add(B[i], 1);
            } else
                mpy[B[i]]++;
        }
        long ans = 0, mod = 1000 * 1000 * 1000 + 7;
        for (int i = 0; i < n; i++) {
            // counts the no of triangles that forms a right angle at the i-th point
            ans = (ans + (mpx[A[i]] - 1) * (mpy[B[i]] - 1)) % mod;
        }
        return (int) ans;
    }

    private static bool Compare(int[] freqA, int[] freqB){
        for(int i=0;i<freqA.Length;i++)
        {
            if(freqA[i] != freqB[i]){
                return false;
            }
        }
        return true;
    }
}
