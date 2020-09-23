public class Square
{
    public double x = 0;
    public double y = 0;
    public double length = 0;    

    // This constructor is for the points.
    public Square(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    // This is a constructor for the square.
    public Square(double x, double y, double length)
    {
        this.x = x;
        this.y = y;
        this.length = length;
    }

    // This method calcualtes the area of the square.
    public static double area(double length)
    {
        double area = length * length;
        return area;
    }

    // This method calculates the perimeter of the square.
    public static double perimeter(double length)
    {
        double perimeter = 4 * length;
        return perimeter;
    }

    // This method checks if Square B intersects Square A.
    public static boolean intersects(Square b, Square a)
    {
        Square l2 = new Square(b.x, b.y);
        Square r2 = new Square((b.x+b.length), (b.y+b.length));
        Square l1 = new Square(a.x, a.y);
        Square r1 = new Square((a.x+a.length), (a.y+a.length));

        if (l1.x > r2.x || r1.x < l2.x || l1.y < r2.y || r1.y > l2.y) 
        { 
            return true; 
        } 
        else
        {
            return false;
        }        
    }

    // This function checks if Square A is in Square B.
    public static boolean contains(Square b, Square a)
    {
        Square l2 = new Square(b.x, b.y);
        Square r2 = new Square((b.x+b.length), (b.y+b.length));
        Square l1 = new Square(a.x, a.y);
        Square r1 = new Square((a.x+a.length), (a.y+a.length));

        if (l1.x >= r2.x && r1.x <= l2.x && l1.y <= r2.y && r1.y >= l2.y) 
        { 
            return true; 
        } 
        else
        {
            return false;
        }   
    }    

    // This function draws both squares.
    public static void draw(Square draw)
    {
        
        double xcoord = (draw.x + draw.length/2);
        double ycoord = (draw.y + draw.length/2);
        double radius = draw.length/2;
        StdDraw.square(xcoord, ycoord, radius);
    }

    public static void main(String[] args)
    {
        // Take in all values for Square A.
        double xcoordA = Double.parseDouble(args[0]);
        double ycoordA = Double.parseDouble(args[1]);
        double lengthA = Double.parseDouble(args[2]);

        Square a = new Square(xcoordA, ycoordA, lengthA);

        double areaA = area(lengthA); // Return Square A's area.
        System.out.println("The area is " + areaA);

        double perimaterA = perimeter(lengthA);// Return Square A's perimeter. 
        System.out.println("The perimeter is " + perimaterA);
        
        // Get values for Square B.
        System.out.print("Enter the upper-left coordinates and the length of a square: ");
        double xcoordB = StdIn.readDouble();
        double ycoordB = StdIn.readDouble();
        double lengthB = StdIn.readDouble();

        Square b = new Square(xcoordB, ycoordB, lengthB);

        // Check if Square A and B intersect.
        if(intersects(b, a) == true)
        {
            System.out.println("It intersects the first square.");
        }
        else 
        {
            System.out.println("It does not intersect the first square.");
        }

        // Check if Square B contains Square A.
        if(contains(b, a) == true)
        {
            System.out.println("It contains the first square.");
        }
        else 
        {
            System.out.println("It does not contain the first square.");
        }

        // Draw Square A and Square B.
        draw(a);
        draw(b);
    }
}