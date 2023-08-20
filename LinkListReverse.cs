public static class LinkListReverse{

    public static ListNode LinkListReverseSolve(ListNode A)
    {
       ListNode prev = null;
        ListNode curr = A;

        while(curr != null)
        {
            ListNode fwd = curr.next;
            curr.next = prev;
            prev = curr;
            curr = fwd;
        }
        return prev;
    }
}