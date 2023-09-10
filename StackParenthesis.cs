/* Problem Description
Given an expression string A, examine whether the pairs and the orders of “{“,”}”, ”(“,”)”, ”[“,”]” are correct in A.

Refer to the examples for more clarity.*/

using System.Collections;

public static class StackParenthesis
{

    public static int SolveStackParenthesis(string A)
    {
        Stack st = new Stack();
        char[] ch_Array = A.ToCharArray();
        for (int i = 0; i < ch_Array.Length; i++)
        {
            if (ch_Array[i] == '(' || ch_Array[i] == '{' || ch_Array[i] == '[')
            {
                st.Push(ch_Array[i]);
            }
            else
            {
                if (ch_Array[i] == ')' && st.Count != 0 && st.Peek().ToString() == "(")
                {
                    st.Pop();
                }
                else if (ch_Array[i] == '}' && st.Count != 0 && st.Peek().ToString() == "{")
                {
                    st.Pop();
                }
                else if (ch_Array[i] == ']' && st.Count != 0 && st.Peek().ToString() == "[")
                {
                    st.Pop();
                }
                else
                {
                    return 0;
                }
            }
        }
        return st.Count == 0 ? 1 : 0;
    }
}