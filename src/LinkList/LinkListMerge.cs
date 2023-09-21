public static class LinkListMerge
{

    public static ListNode SolveLinkListMerge(ListNode A, ListNode B)
    {
        ListNode temp;
        if (A.val < B.val)
        {
            temp = A;
            A = A.next;
        }
        else
        {
            temp = B;
            B = B.next;
        }

        ListNode head = temp;
        while (A != null && B != null)
        {
            if (A.val < B.val)
            {
                temp.next = A;
                A = A.next;
            }
            else
            {
                temp.next = B;
                B = B.next;
            }
            temp = temp.next;
        }

        if (A == null)
        {
            temp.next = B;
        }
        else
        {
            temp.next = A;
        }
        return head;
    }
}