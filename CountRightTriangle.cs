// Problem Description
// You are given two strings, A and B, of size N and M, respectively.

// You have to find the count of all permutations of A present in B as a substring. You can assume a string will have only lowercase letters.
// ex: 
// Input
// A = "abc"
// B = "abcbacabc"
// output - 5
public static class CountRightTriangle {
    public static int SolveCountRightTriangle(string A, string B) {
        int[] freqA = new int[26];
        int[] freqB = new int[26];
        int ans = 0;
        for(int i=0;i<A.Length;i++)
        {
            freqA[A[i] - 'a']++;
        }

        for(int i=0;i<B.Length;i++){
         freqB[B[i]-'a']++;
         //when i will be at index >=A.length, then remove leftmost char freq from freqB as we are sliding window by one char
         if(i>=A.Length){
             freqB[B[i-A.Length]-'a']--;
         }
         if(Compare(freqA, freqB)){
             ans++;
         }
        }

        return ans;
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
