// This class computes the sum of natural numbers in a given range entered by the user using recursion.
public class NumbersRangeSum
{
    // Declared this value outside of either methods so I could use it in both.
    public static int sum;

    // This method uses recursion to get the sum between the a and b range.
    public static int getSum(int a, int b)
    {
        if (a <= b)
        {
            sum = sum + a;
            return getSum(a + 1, b);
        }
        else
        {
            return sum;            
        }

    }
    public static void main(String[] args)
    {
        int start = Integer.parseInt(args[0]);
        int end = Integer.parseInt(args[1]);
        if( start < 0 || end < 0) // This ends the program if there is a negative number since we want natural numbers.
        {
            System.out.print("You cannot enter a negative value.");
            return;
        }
        
        // This function will do what it's intended to do if start is less than or equal to end.
        if(start <= end)
        {
            sum = getSum(start, end);
    
            System.out.print("The sum of natural numbers in range[" + start + ", " + end + "] is " + sum + ".");
        }
        else 
        {
            System.out.print("The starting point needs to be less than (before) the ending point.");
        }
    }
}