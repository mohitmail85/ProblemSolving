public class PathDirectedGraph
{
    public bool GetPath(int A, List<List<int>> B)
    {
        int n = B.Count;
        bool[] vistedNodes = new bool[A + 1];
        List<int>[] nodes = new List<int>[A + 1];

        for (int i = 0; i <= A; i++)
        {
            nodes[i] = new List<int>();
        }

        for (int i = 0; i < B.Count; i++)
        {
            nodes[B[i][0]].Add(B[i][1]);
        }

        Queue<int> queue = new Queue<int>();
        int s = B[0][0];
        queue.Enqueue(s);
        vistedNodes[s] = true;

        while (queue.Count > 0)
        {
            int u = queue.Dequeue();
            int edgescount = nodes[u].Count;

            for (int i = 0; i < edgescount; i++)
            {
                int v = nodes[u][i];
                if (vistedNodes[v] != true)
                {
                    queue.Enqueue(v);
                    vistedNodes[v] = true;
                }
            }
        }

        return vistedNodes[A];
    }

}