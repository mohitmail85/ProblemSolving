/* Problem Description
An arithmetic expression is given by a string array A of size N. Evaluate the value of an arithmetic expression in Reverse Polish Notation.

Valid operators are +, -, *, /. Each string may be an integer or an operator.

Note: Reverse Polish Notation is equivalent to Postfix Expression, where operators are written after their operands.*/

using System.Collections;
using System.Text;

public static class StackReversePolishNotation
{

    public static int SolveStackReversePolishNotation(List<string> A)
    {
        Stack st = new Stack();
        int res;
        for (int i = 0; i < A.Count; i++)
        {
            int x;
            if (int.TryParse(A[i].ToCharArray(), out x))
            {
                st.Push(x);
            }
            else
            {
                int a = int.Parse(st.Pop().ToString());
                int b = int.Parse(st.Pop().ToString());
                int c = Operations(a, b, A[i]);
                st.Push(c);

            }
        }
        res = int.Parse(st.Peek().ToString());
        return res;
    }

    public static int Operations(int a, int b, string operands)
    {
        int res = 0;
        switch (operands)
        {
            case "+":
                res = b + a;
                break;
            case "-":
                res = b - a;
                break;
            case "*":
                res = b * a;
                break;
            case "/":
                res = b / a;
                break;

        }
        return res;
    }
}