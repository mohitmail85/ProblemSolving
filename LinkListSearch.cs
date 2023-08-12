public class LinkListSearch{

    public int SolveSearch(ListNode A, int B)
    {
        while(A!= null)
        {
            if(A.val == B)
            {
                return 1;
            }
            else{
               A = A.next;
            }
        }
        return A?.val == B ? 1: 0;
    }
}