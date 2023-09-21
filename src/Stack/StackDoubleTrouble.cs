/* You have a string, denoted as A.

To transform the string, you should perform the following operation repeatedly:
Identify the first occurrence of consecutive identical pairs of characters within the string.
Remove this pair of identical characters from the string.
Repeat steps 1 and 2 until there are no more consecutive identical pairs of characters.
The final result will be the transformed string.*/

using System.Collections;
using System.Text;

public static class StackDoubleTrouble
{

    public static string SolveStackDoubleTrouble(string A)
    {
        Stack st = new Stack();
        StringBuilder res = new StringBuilder();
        st.Push(A[0]);
        for (int i = 1; i < A.Length; i++)
        {
            if (st.Count != 0 && A[i].ToString() == st.Peek().ToString())
            {
                st.Pop();
            }
            else
            {
                st.Push(A[i]);
            }
        }

        while (st.Count > 0)
        {
            res.Append(st.Pop());
        }
        return string.Join("", res.ToString().Reverse());
    }
}