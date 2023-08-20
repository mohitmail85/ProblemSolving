
using System.Text;
using Newtonsoft.Json;
using System.Collections;

public class Program
{
    public static void Main()
    {

        // List<int> A = new List<int>{3, 5, 10};
        //List<List<int>> B = new List<List<int>>{ new List<int>{0,2}, new List<int>{1,4}};
        // Console.WriteLine();
        ListNode node1 = new ListNode(1);
        ListNode node2 = new ListNode(5);
        ListNode node3 = new ListNode(6);
        ListNode node4 = new ListNode(2);
        ListNode node5 = new ListNode(3);
        ListNode node6 = new ListNode(4);
        node1.next = node2;
        node2.next = node3;
        node3.next = node4;
        node4.next = node5;
        node5.next = node6;
        node6.next = null;
        var res = LinkListMid.SolveLinkListMid(node1);

    }

}