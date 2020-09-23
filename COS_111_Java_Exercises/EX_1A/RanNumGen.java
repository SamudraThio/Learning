/* This class takes an integer command-line argument "n" that indicates the number of random numbers
   to generate and uses the method "Math.random()" to print uniform random values between 1 and 100,
   then prints the minimum and maximum value. */
public class RanNumGen
{
    public static void main(String[] args)
    {
        int n = Integer.parseInt(args[0]); 

        /* The min and max values are declared here and will be used to identify the 
            highest and lowest numbers that we generate in the console */
        int minValue = 0;
        int maxValue = 0;

        // This for loop will return a random number for n iterations (determined by the input)
        for (int i = 0; i < n; i++)
        {
            Double randomNumber = Math.random();
            int value = (int) (randomNumber * 1 * 100); // Contains the random number value between 1 to 100
            System.out.print(value + "    ");
            if (maxValue==0 & minValue==0) // Initial value placed in minValue and maxValue
            {
                maxValue = minValue = value;
            }
            else if (value > maxValue) // If a value is higher than maxValue, the value becomes the new maxValue
            {
                maxValue = value;
            }
            else if (minValue > value) // If minValue is higher than value, the value becomes the new minValue
            {
                minValue = value;
            }
        }
        System.out.println("\nThe minimum value is " + minValue + ".");    
        System.out.println("The maximum value is " + maxValue + ".");
    }   
}