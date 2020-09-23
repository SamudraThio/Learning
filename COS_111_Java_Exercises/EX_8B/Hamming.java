import java.util.Arrays;

public class Hamming
{

    int difference = 0;

    // Need constructor that takes in int[] x and int y that I can use to put in a recursive function

    // This is a method to find the Hammings that are different from the command line input.
    public static int[] FindDifferences(int[] num, int difference)
    {
        
        for (int i = 0; i < difference; i++)
        {
            if (num[i] == 0)
            {
                num[i] = 1;
            }
            else if (num[i] == 1)
            {
                num[i] = 0;
            }            
        }

        // Add an array that adds the new value if it is not a duplicate.
        // Recursion to do this method again until there are no more values to add

        return num;        
    }

    public static void main(String[] args)
    {
        int difference = Integer.parseInt(args[0]); // Takes in the distance you want between Hammings.
        String bits = args[1]; // Takes in the bit string.

        // Converts the bit string to an int array.
        int[] num = new int[bits.length()];

        for(int i = 0; i < bits.length(); i++)
        {
            num[i] = bits.charAt(i);
        }
        
        FindDifferences(num, difference);
        
        System.out.print(Arrays.toString(num)); // Print all values in the array that holds all the values in the new array that isholding all the differences.
    }
}