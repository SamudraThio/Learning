// This program takes the first argument as the count of the remaining arguments to be counted as either between 1 to 50 or 51 to 100.
public class Distribution100
{
    public static void main(String[] args)
    {
        // This will take the first argument and make it the length of the array that will hold the rest of the arguments
        int count = Integer.parseInt(args[0]);
        int[] userEntrys;
        userEntrys = new int[count];

        // These variables will hold the counter info.
        int lowerCount = 0;
        int higherCount = 0;

        // This for loop will take in the arguments and put it in the array.
        for(int i = 1 ; i < args.length; i++)
        {
            userEntrys[i-1] = Integer.parseInt(args[i]);
        }

        // This for loop will add a count to either lowerCount or higherCount.
        for (int i : userEntrys) 
        {
            if (i >= 1 && i <= 50)
            {
                lowerCount++;
            }
            else if (i > 50 && i <= 100)
            {
                higherCount++;
            }
        }

        System.out.println(lowerCount + " numbers entered are less than or equal to 50.");
        System.out.println(higherCount + " numbers entered are greater than 50.");
    }
}