// This class takes an integer command-line argument and creates a boolean[][] array that marks true if both arrays are relatively prime. This only works up to n = 10.
public class RelativelyPrimeArray
{
    public static void main(String[] args)
    {
        // Accepts the command-line argument.
        int n = Integer.parseInt(args[0]);
        // Creates the Boolean[][] array.
        Boolean[][] rpa = new Boolean[n+1][n+1];
        
        // This for loop creates the head which is a row of numbers equivalent to n.
        for (int i = 0; i <= n ; i++)
        {
            if (i == 0)
            System.out.print("  ");
            else 
            System.out.print(i + " ");            
        }
        System.out.println();

        for (int i = 1; i <= n; i++)
        {        
            System.out.print(i + " "); // This outputs the start of each column with the number then T/F.
            for (int j = 1; j <= n; j++)
            {                
                if (i == j) // If i and j are equal, it outputs a single space.
                {
                    System.out.print("  ");
                }     
                else if (i > j) // This outputs F for any value that is not a prime number and T for prime number.
                {
                    if (i % j == 0 && i != 1 && j != 1)    
                    {
                        System.out.print("F ");
                    }
                    else if (gcd(i, j) == 2) // The GCD function will generate common factors which will ID if the number is not prime. 
                    {
                        System.out.print("F ");
                    }
                    else if (gcd(i, j) == 3)
                    {
                        System.out.print("F ");
                    }
                    else 
                    {
                        System.out.print("T ");
                    }  
                }
                
                else if (j > i) // This outputs F for any value that is not a prime number and T for prime number.
                {
                    if (j % i == 0 && j != 1 && i != 1)
                    {               
                        System.out.print("F ");
                    }
                    else if (gcd(j, i) == 2)
                    {
                        System.out.print("F ");
                    }
                    else if (gcd(j, i) == 3)
                    {
                        System.out.print("F ");
                    }
                    else 
                    {
                        System.out.print("T ");
                    }   
                }                 
            }
            System.out.println();            
        }
    }
    // This is the Euclid's Algorithm that finds the greatest common divisor
    public static int gcd(int a, int b)
    {
        while (b > 0)
        {
            int c = a % b;
            a = b;
            b = c;
        }
        
        return a;
    }
}