// This class implements a data type, Point, which then calculates the distance between two points.
public class Point
{
    private final double x1, y1, z1;

    public Point(double x1, double y1, double z1)
    { // This is a constructor for the data type, Point.
        this.x1 = x1;
        this.y1 = y1;
        this.z1 = z1;
    }
    
    public String ToString()
    { // Override the ToString to print out the point's values.
        return "(" + x1 + ", " + y1 + ", " + z1 + ")";
    }

    public double distanceto(Point q)
    { // This calculates the Euclidean distance between two points. 
        double distance = Math.sqrt(Math.pow(q.x1 - x1, 2) + Math.pow(q.y1 - y1, 2) + Math.pow(q.z1 - z1, 2));
        return distance;
    }

    public static void main(String[] args)
    {
        // Take the 6 numbers and convert them to doubles.
        double pointA = Double.parseDouble(args[0]);
        double pointB = Double.parseDouble(args[1]);
        double pointC = Double.parseDouble(args[2]);

        double pointD = Double.parseDouble(args[3]);
        double pointE = Double.parseDouble(args[4]);
        double pointF = Double.parseDouble(args[5]);

        // Create new Point instances
        Point pointOne = new Point(pointA, pointB, pointC);
        Point pointTwo = new Point(pointD, pointE, pointF);

        // Get the distance between both points
        double distance = pointOne.distanceto(pointTwo);

        System.out.println("The first point is " + pointOne.ToString());
        System.out.println("The second point is " + pointTwo.ToString());
        StdOut.printf("Their Euclidean distance is %.2f", distance);        
    }
}