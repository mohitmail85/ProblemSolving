public class Circle {
	    float pi=3.14f;
        int r;
        public Circle(int r){
            this.r = r;
        }

		public float perimeter(){
			return 2 * pi * r;
			
		}
		
		public float area(){
			return pi * r * r;
			
		}
};

/*
    Circle a = new Circle(3)  // Radius = 3
	a.perimeter() // 18.84
    a.area() // 28.26
*/