// Problem Description
// Given two arrays of integers A and B of size N each, where each pair (A[i], B[i]) for 0 <= i < N represents a unique point (x, y) in 2D Cartesian plane.

// Find and return the number of unordered triplets (i, j, k) such that (A[i], B[i]), (A[j], B[j]) and (A[k], B[k]) form a right-angled triangle with the triangle having one side parallel to the x-axis and one side parallel to the y-axis.
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
