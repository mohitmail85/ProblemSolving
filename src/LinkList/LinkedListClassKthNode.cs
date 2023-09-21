public class LinkedListClassKthNode {
    public int solve(ListNode A, int B) {
            for(int i=0;i<B;i++)
            {
                A = A.next;
            }
            return A.val;
    }
}

// if(A == null)
//         {
//             A = curr;
//             return A;
//         }

//         if(C == 0)
//         {
//             curr.next = A;
//             A = curr;
//             return A;
//         }
//         else
//         {
//             ListNode temp = A;
//             for(int i=1;i<C;i++)
//             {
//                 if(temp.next == null)
//                 {
//                     temp.next = curr;
//                     return A;
//                 }

//                     temp = temp.next;
//             }
//             curr.next = temp.next;
//             temp.next = curr;
//             return A;
//         }