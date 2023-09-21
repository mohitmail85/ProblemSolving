public static class LinkListMid
{

    public static int SolveLinkListMid(ListNode A)
    {
        ListNode slow_ptr = A;
        ListNode fast_ptr = A;

        while (fast_ptr.next != null && fast_ptr.next.next != null)
        {
            slow_ptr = slow_ptr.next;
            fast_ptr = fast_ptr.next.next;
        }

        //once the above loop ends
        //if the size of a linked list is even then the fast pointer will be pointing at second last node
        //else if the size of a linked list is odd then the fast pointer will be pointing at last node;
        return fast_ptr.next != null ? slow_ptr.next.val : slow_ptr.val;

    }
}