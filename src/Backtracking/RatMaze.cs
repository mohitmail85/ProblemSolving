public class RatMaze
{
    List<int> row = new List<int> { 0, 0, 1, -1 };
    List<int> col = new List<int> { 1, -1, 0, 0 };
    public int SolveRatMaze(List<List<int>> A)
    {
        int rows = A.Count;
        int cols = A[0].Count;
        int result = 0;
        for (int k = 0; k < rows; k++)
        {
            for (int m = 0; m < cols; m++)
            {
                if (A[k][m] == 1)
                {
                    result = IsSafe(A, rows, cols, k, m); /* find indexes where 1 is located and start covering paths */
                    break;
                }
            }
        }
        return result;

    }

    public int IsSafe(List<List<int>> grid, int rows, int cols, int i, int j)
    {
        if (i < 0 || j < 0 || i >= rows || j >= cols || grid[i][j] == -1)
        {
            return 0;
        }

        if (grid[i][j] == 2)
        {
            for (int l = 0; l < rows; l++)
            {
                for (int m = 0; m < cols; m++)
                {
                    if (grid[l][m] == 0)
                    {
                        return 0;
                    }
                }
            }
            return 1;
        }

        grid[i][j] = -1;
        int result = 0;
        for (int k = 0; k < 4; k++)
        {
            result += IsSafe(grid, rows, cols, (i + row[k]), (j + col[k]));
        }
        grid[i][j] = 0;
        return result;
    }
}
