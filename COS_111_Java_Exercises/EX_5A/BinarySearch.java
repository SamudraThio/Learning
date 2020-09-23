// This program modifies the given BinarySearch algorithm to search for integers from a given txt file.
// If the search key is in the array, it returns the largest index i for which a[i] is equal to key
// Otherwise, it returns –i where i is the largest index such that a[i] is less than key.
public class BinarySearch
{
    // This was converted from a String to an int key and array.
    public static int search(int key, int[] a)
    { 
        return search(key, a, 0, a.length-1); 
    }

    // This recursion loops within itself to search for the value in the array by halving itself each time.
    public static int search(int key, int[] a, int low, int high)
    { // Search for key in a[lo, high).        
        
        int mid = (high + low) / 2;
        
        if (a[high] < key) 
        {
            return a[high] * -1;
        }
        
        if (a[mid] == key) 
        {
            return key;
        }        
        else if (key < a[mid])
        {
            return search(key, a, low, mid-1);
        }
        else 
        {
            return search(key, a, mid+1, high);
        }        
    }

    public static void main(String[] args)
    { 
        In in = new In(args[0]); // Takes in the input.txt file.
        int[] a = in.readAllInts(); // Converts all the integers in the file to an element in array a.
        int key = Integer.parseInt(args[1]); // Takes the second input from the command line to be the key.

        int output = search(key, a); // Searches for the key in array a
        StdOut.println(output); // Outputs either the value (if it is in the array) or negative of the closest value less than the key.
    }
}