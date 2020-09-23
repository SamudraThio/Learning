// This class test if three integer values entered as command line arguments could be sides of a triangle.
public class TriangularTest
{
    // This method will determine true if input values are less than or equal to the values added.
    public static void IsTriangular(int a, int b, int c) // Input for this method are three integers.
    {
        if ( a <= b + c && b <= a + c && c <= a + b )
        {
            System.out.println("True");
        }
        else 
        {
            System.out.println("False");
        }

    }
    public static void main(String[] args)
    {
        // User will enter three integers which are stored to the sides of the triangle.
        int sideA = Integer.parseInt(args[0]);
        int sideB = Integer.parseInt(args[1]);
        int sideC = Integer.parseInt(args[2]);

        IsTriangular(sideA, sideB, sideC); // Inputting the three sides into the function since it requires three integers.
    }
}