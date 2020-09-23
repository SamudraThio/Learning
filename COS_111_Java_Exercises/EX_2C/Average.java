// This class will read lines from standard input containing a name and 3 integers (Ex. Jack 3 5 2) and print the name, integers, and averages(2 decimal places).
public class Average
{
    public static void main(String[] args)
    {
        // User enters the number of inputs they to calculate an average for.
        int n = Integer.parseInt(args[0]);

        // Allows user to indefinitely enter  names and 3 integers. Each input is put into an array. Ctrl+Z and enter to end.
        String[] inputs = StdIn.readAllLines();

        // For the number of inputs that were inserted, this will output the name, numbers and average.
        for (int i = 0; i < n; i++)
        {
            String[] split = inputs[i].split(" "); // Splits the string per array.
            String name = split[0];
            
            // Each number is stored, then added before finding the average.
            int firstNumber = Integer.parseInt(split[1]);
            int secondNumber = Integer.parseInt(split[2]);
            int thirdNumber = Integer.parseInt(split[3]);
                
            int sum = firstNumber + secondNumber + thirdNumber;
            float average = sum / (float) 3; // Converted the int to a float here to get the decimal values.
                 
            // Prints the information per requirements.
            StdOut.printf("%-8s %4d %4d %4d %7.2f", name, firstNumber, secondNumber, thirdNumber, average);
            StdOut.println();
        }
    }
}