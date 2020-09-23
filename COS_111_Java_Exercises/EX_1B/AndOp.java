// This class prints true if two double values given as command line arguments are between 0 and 1
public class AndOp
{
    public static void main(String[] args)
    {
        double valueOne = Double.parseDouble(args[0]); // Recieves the first command line argument
        double valueTwo = Double.parseDouble(args[1]); // Recieves the second command line argument

        // if statement to filter out the doubles that fit our requirements
        if (valueOne < 1.0 && valueOne > 0.0 && valueTwo < 1.0 && valueTwo > 0.0)
            System.out.println("true");
        else
            System.out.println("false");
    }
}