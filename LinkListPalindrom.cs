public static class LinkListPalindrom
{

    public static int SolveLinkListPalindrom(ListNode A)
    {
        ListNode slow_ptr = A;
        ListNode fast_ptr = A;
        ListNode second_half, prev_of_slow_ptr = A;
        ListNode midnode = null;

        int res = 1;
        if (A != null && A.next != null)
        {
            while (fast_ptr != null && fast_ptr.next != null)
            {
                fast_ptr = fast_ptr.next.next;
                prev_of_slow_ptr = slow_ptr;
                slow_ptr = slow_ptr.next;
            }
        }

        if (fast_ptr != null)
        {
            midnode = slow_ptr;
            slow_ptr = slow_ptr.next;
        }

        second_half = slow_ptr;
        prev_of_slow_ptr.next = null;
        second_half = ReverseLinkList(second_half);
        res = compareLists(A, second_half);

        return res;
    }

    private static ListNode ReverseLinkList(ListNode A)
    {
        ListNode prev = null;
        ListNode curr = A;

        while (curr != null)
        {
            ListNode fwd = curr.next;
            curr.next = prev;
            prev = curr;
            curr = fwd;
        }
        return prev;
    }

    private static int compareLists(ListNode head1, ListNode head2)
    {
        ListNode temp1 = head1;
        ListNode temp2 = head2;
        while (temp1 != null && temp2 != null)
        {
            if (temp1.val == temp2.val)
            {
                temp1 = temp1.next;
                temp2 = temp2.next;
            }
            else return 0;
        }
        /* Both are empty reurn 1*/
        if (temp1 == null && temp2 == null)
            return 1;
        /* Will reach here when one is NULL
           and other is not */
        return 0;
    }
}