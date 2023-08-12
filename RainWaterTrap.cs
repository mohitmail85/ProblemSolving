public class RainWaterTrap {

	public List<int> FindLMax(List<int> A)
	{
		List<int> lMax = new List<int>();

		int max = A[0];
		for(int i=0;i<A.Count;i++)
		{
			if(A[i] > max)
			{
				lMax.Add(A[i]);
				max = A[i];
			}
			else
			{
				lMax.Add(max);
			}
		}
		return lMax;
	}

	public List<int> FindRMax(List<int> A)
	{
		List<int> rMax = new List<int>();
		for(int j=0;j<A.Count;j++)
		{
			rMax.Add(0);
		}

		int max = A[0];
		for(int i=A.Count-1;i>=0;i--)
		{
			if(A[i] > max)
			{
				rMax[i] = A[i];
				max = A[i];
			}
			else
			{
				rMax[i]= max;
			}
		}
		return rMax;
	}

	public int GetRainWaterTrap(List<int> A)
	{
		List<int> rmax = FindRMax(A);
		List<int> lmax = FindLMax(A);
		int totalWaterTrapped = 0;
		for(int i=0;i<A.Count;i++)
		{
			int trapWaterperBuilding = Math.Min(rmax[i], lmax[i]) - A[i];
			totalWaterTrapped = totalWaterTrapped + trapWaterperBuilding;

		}
		return totalWaterTrapped;
	}
	    
};

