// This program takes an integer command line argument 'n' and prints the nth string from the first string.

// Imported this library to use functions that could count and make new stacks.
import java.util.Stack;

public class LineNum
{   
    public static String[] items;
    public int n = 0;

    // Function for the while statement to take in the inputs.
    public boolean isEmpty()
    {
        return (n == 0);
    }

    // Function for push.
    public void push(String item)
    {
        items[n++] = item;
    }

    // Function for pop.
    public String pop()
    {
        return items[--n];
    }
    public static void main(String[] args)
    {
        int searchInput = Integer.parseInt(args[0]); // User input for the command argument "n".

        Stack<String> stack = new Stack<String>(); // Creates a new stack.

        // This function takes in all the inputs and pushes them on the stack.
        while(!StdIn.isEmpty())
        {
            String item = StdIn.readString(); 
            stack.push(item);
        }
        
        int dequeue = stack.size() - searchInput; // Calculate the number of items to pop to get to the nth.

        // This pops all the items on top of the nth value.
        for(int i = 0; i < dequeue ; i++)        
        {
            stack.pop();
        }

        // Pops the nth value.
        StdOut.print(searchInput + " from the first is " + stack.pop());
    }
}