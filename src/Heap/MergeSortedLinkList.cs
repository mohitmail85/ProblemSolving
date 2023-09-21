/**
 * Definition for singly-linked list.
 * class ListNode {
 *     public int val;
 *     public ListNode next;
 *     ListNode(int x) { val = x; next = null; }
 * }
 */
using System.Collections.Generic;
using System;


class MergeSortedLinkList
{

    public ListNode mergeKLists(List<ListNode> A)
    {

        Dictionary<int, List<ListNode>> map = new Dictionary<int, List<ListNode>>();
        ListNode node;
        List<ListNode> list;
        int val;

        foreach (ListNode heads in A)
        {
            node = heads;
            while (node != null)
            {
                val = node.val;

                if (map.ContainsKey(val))
                {
                    list = map[val];
                    list.Add(node);
                }
                else
                {
                    list = new List<ListNode>();
                    list.Add(node);
                    map[val] = list;
                }

                node = node.next;
            }
        }
        PriorityQueue<List<ListNode>> pq = new PriorityQueue<List<ListNode>>(true);

        ListNode head = null;
        node = null;

        foreach (KeyValuePair<int, List<ListNode>> entry in map)
        {

            list = entry.Value;
            pq.Enqueue(entry.Key, entry.Value);

        }
        while (pq.Count > 0)
        {
            list = pq.Dequeue();
            foreach (ListNode n in list)
            {
                if (head == null)
                    head = n;
                if (node != null)
                    node.next = n;
                node = n;
            }

        }


        return head;

    }
}