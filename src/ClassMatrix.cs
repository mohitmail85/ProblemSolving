public class Matrix {
    
    // Define properties here
		int r;
        int c;
        int[,] mat;
		
	// Define constructor here
	public Matrix(int r, int c)
    {
        this.r= r;
        this.c = c;
        this.mat = new int[r,c];
    }
	
	public void input(){
		Console.WriteLine($"Enter {r} rows with {c} space-separated integers in each row:");
        for (int i = 0; i < r; i++)
        {
            string[] rowValues = Console.ReadLine().Split(' ');
            for (int j = 0; j < c; j++)
            {
                mat[i, j] = int.Parse(rowValues[j]);
            }
        }
	}
	
	public Matrix add(Matrix x){
		// Complete the function
		Matrix res = new Matrix(r,c);
        for(int i=0;i<r;i++)
        {
            for(int j=0;j<c;j++)
            {
                res.mat[i,j] = this.mat[i,j] + x.mat[i,j];
            }
        }
        return res;
	}
	
	public Matrix subtract(Matrix x){
		// Complete the function
		Matrix res = new Matrix(r,c);
        for(int i=0;i<r;i++)
        {
            for(int j=0;j<c;j++)
            {
                res.mat[i,j] = this.mat[i,j] - x.mat[i,j];
            }
        }
        return res;
	}
		
	public Matrix transpose(){
		// Complete the function
        Matrix res = new Matrix(r,c);
        for(int i=0;i<r;i++)
        {
            for(int j=0;j<c;j++)
            {
                res.mat[j,i] = this.mat[i,j];
            }
        }
        return res;
		
	}
	
	public void print(){
		// Complete the function
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write(mat[i, j] + " ");
            }
            Console.WriteLine();
        }
		
	}
}

/*
    Matrix a = new Matrix(10, 5)  // 10 rows, 5 columns
	a.input() 
	Matrix b = new Matrix(10, 5)  // 10 rows, 5 columns
	b.input()
    Matrix c1 = a.add(b)
    Matrix c2 = a.subtract(b)
    Matrix c3 = a.transpose()
    a.print()
*/