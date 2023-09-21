public class PrintNumber {
		
		public void printNum(int n)
    {
        if(n==1)
        {
            Console.Write(1 + " ");
            return;
        }
        
        Console.Write(n + " ");
        printNum(n-1);
        return;
    }

    public  int bar(int x, int y){
        if (y == 0)   return 0;
        return (x + bar(x, y-1));
    }

    public int foo(int x, int y){
        if (y == 0) return 1;
        return bar(x, foo(x, y-1));
    }

};
