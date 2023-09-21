 public class ListNode {
    public int val;
     public ListNode next;
     public ListNode(int x) {this.val = x; this.next = null;}
  }

public class Solution {
    public ListNode solve(ListNode A, int B, int C) {
        ListNode curr = new ListNode(B);

        if(A == null)
        {
            A = curr;
            return A;
        }

        if(C == 0)
        {
            curr.next = A;
            A = curr;
            return A;
        }
        else
        {
            ListNode temp = A;
            for(int i=1;i<C;i++)
            {
                if(temp.next == null)
                {
                    temp.next = curr;
                    return A;
                }

                    temp = temp.next;
            }
            curr.next = temp.next;
            temp.next = curr;
            return A;
        }
    }
}