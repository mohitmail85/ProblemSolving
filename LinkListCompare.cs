public class LinkListCompare{

    public int SolveCompare(ListNode A, ListNode B)
    {
        while(A!= null)
        {
            if(A.val == B.val)
            {
                A = A.next;
                B = B.next;
            }
            else{
                return 0;
            }
        }
        return 1;
    }
}