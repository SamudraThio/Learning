// This program modifies the LinkedStackOfStrings provided in the textbook and adds a find() method that 
// takes a string as an argument. It returns true if the string argument is found, and false otherwise.
public class LinkedStackOfStrings
{
    private static Node first; // Declares node. Modified to static.
    
    // No modifications from textbook example.
    private class Node 
    {
        private String item;
        private Node next;
    }

    // No modifications from textbook example.
    public boolean isEmpty()
    { 
        return (first == null);
    }

    // This function searches for the string entered in the command line.
    public static boolean find(String searchItem)
    {
        // If the stack is empty, this returns false.
        if (first == null)
        {
            return false;
        }

        String item = first.item; // The first item of the stack.

        if (item.equals(searchItem)) // If the first item of the stack is equal to the string from the command line. 
        {
            return true;
        }
        else 
        {
            first = first.next; // Move to the next item in the stack and apply a recursion. (Copies pop function)
            return find(searchItem);  
        }
    }

    // No modifications from textbook example.
    public void push(String item)
    { // Insert a new node at the beginning of the list.
        Node oldFirst = first;
        first = new Node();
        first.item = item;
        first.next = oldFirst;
    }

    // No modifications from textbook example.
    public String pop()
    { // Remove the first node from the list and return item.
        String item = first.item;
        first = first.next;
        return item;
    }
    public static void main(String[] args)
    {
        String searchItem = args[0]; // Takes a string as the argument we are finding for.
        LinkedStackOfStrings stack = new LinkedStackOfStrings(); // Initiate stack.

        // Takes in strings from user inputs.
        while(!StdIn.isEmpty())
        {
            String input = StdIn.readString();
            stack.push(input);
        }

        boolean result = find(searchItem); // Looks for the argument in the stack and returns true/false.

        // Depending on the find method, we print whether or not we find the argument in the stack.
        if (result == true)
        {
            StdOut.println(searchItem + " exists in the linked stack");
        }
        else 
        {
            StdOut.println(searchItem + " does not exist in the linked stack");
        }
    }
}