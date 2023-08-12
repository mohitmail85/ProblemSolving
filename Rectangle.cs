class Rectangle {
    // Define properties here
    int l;
    int b;
    public Rectangle(int l,int b)
    {
        this.l = l;
        this.b = b;

    }
    


    public int perimeter(){
		// Complete the function
        return 2*(l + b);
		
	}
	
	public int area(){
		// Complete the function
        return l*b;
		
	}
}

/*
    Rectangle a = new Rectangle(2, 3)  // Length = 2, Breadth = 3
	a.perimeter() // Should give 10
    a.area() // Should give 6
*/