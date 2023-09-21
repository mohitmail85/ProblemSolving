// Problem Description
// You are given an array A of integers that represent the lengths of ropes.

// You need to connect these ropes into one rope. The cost of joining two ropes equals the sum of their lengths.

// Find and return the minimum cost to connect these ropes into one rope.
public class ConnectRopesHeap
{
    public int SolveConnectRope(List<int> A)
    {
        PriorityQueue<int> pq = new PriorityQueue<int>(true);
        int cost = 0;

        foreach (int x in A)
        {
            pq.Enqueue(x, x);
        }

        while (pq.Count > 1)
        {

            // Take the two ropes with smallest length
            int l1 = pq.Dequeue();
            int l2 = pq.Dequeue();
            // cost of combining these two ropes is l1 + l2.
            cost += l1 + l2;

            // add the newly formed rope of length l1 + l2 to the queue.
            pq.Enqueue(l1 + l2, l1 + l2);
        }

        return cost;
    }

}


