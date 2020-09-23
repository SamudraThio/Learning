// This class identifies the last digit of a 10-digit ISBN if the user provides the first 9.
public class ISBN
{
    // This method calculates the sum of the previous 9 ISBN numbers multiplied by a certain number depending on the position.
    public static int CheckSum(int[] a)
    {
        int sum = 0;
        int modular = 0;

        for(int i = 0, j = 10; j > 1; i++, j--)
        {
            sum = sum + a[i] * j;
        }

        if(sum % 11 == 0) // If the sum has no remainder from being divided by 11, the last digit is 0.
        {
            return 0;
        }
        else
        {
            modular = 11 - (sum % 11); // Else the remainder subtracted from 11 is the last digit.
            return modular;
        }        
    }

    public static void main(String[] args)
    {
        // User inputs the first 9 digits of the ISBN.
        String userInput = args[0];
        String[] firstNine = userInput.split(""); // The input is split into an array per char.
        int[] calculateLast = new int[firstNine.length]; // Initialize the array to match the length of the first array.

        // Convert all the strings to digits in the new array.
        for (int i = 0; i < 9; i++)
        {
            calculateLast[i] = Integer.parseInt(firstNine[i]);
        }

        // Put the array through the CheckSum to recieve the last digit of the ISBN.
        int lastNumber = CheckSum(calculateLast);

        System.out.print("The ISBN number would be " + userInput + lastNumber);
    }
}