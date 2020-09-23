/* This class uses one "for loop" and one "if statement" to print integers from 1 to 100 
   with ten integers per line */
public class LC
{    public static void main(String[] args)
    {
        /* Using a for loop to count the iterations and an if statement to do a different action every 
           10 intergers. Originally, I declared int i = 1 outside the loop, but then I remembered that 
           we could declare it in the for statement */
        for (int i = 1; i <= 100; i++)
        {
            if (i % 10 == 0) // This modular operator finds every 10 numbers
            {
                System.out.println(i + " "); // This prints a new line every 10 items, along with the integer
            }
            else 
            {
                System.out.print(i + " "); // This just prints the integer without a new line
            }
        }
    }
}