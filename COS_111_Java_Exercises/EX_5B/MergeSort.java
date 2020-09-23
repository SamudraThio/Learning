// This program modifies Merge from the textbook to search for a subarray.
// User provides the starting and ending index for the sub array to be sorted and an unsorted list.
// The program will print out a list where the string between the indexes are sorted alphabetically.
public class MergeSort
{
    // This function inputs a String array and generates values to go into the next function. (No changes from Merge example.)
    public static void sort(String[] a)
    {
        String[] aux = new String[a.length];
        sort(a, aux, 0, a.length);
    }

    // This function sorts the input alphabetically. (No changes from Merge example.)
    private static void sort(String[] a, String[] aux, int low, int high)
    { 
        if (high - low <= 1) 
        {
            return;
        }

        int mid = low + (high-low)/2;
        sort(a, aux, low, mid);
        sort(a, aux, mid, high);
        int i = low, j = mid;

        for (int k = low; k < high; k++)
            if (i == mid) 
            {
                aux[k] = a[j++];
            }
            else if (j == high) 
            {
                aux[k] = a[i++];
            }
            else if (a[j].compareTo(a[i]) < 0) 
            {
                aux[k] = a[j++];
            }
            else 
            {
                aux[k] = a[i++];
            }

        for (int k = low; k < high; k++)
        a[k] = aux[k];
    }
    public static void main(String[] args)
    { 
        int start = Integer.parseInt(args[0]); // First input is the starting index for the subarray.
        int end = Integer.parseInt(args[1]); // Second input is the ending index for the subarray.
        String[] a = new String[args.length-2]; // Length subtracts 2 since arg[0] & arg[1] is used for start/end.
        
        // Loop to copy the remaining strings into a string array. 
        for (int i = 0; i < a.length; i++)
        {
            a[i] = args[i+2];
        }
        
        // Loop to create the substring.
        String[] b = new String[end - start + 1];
        for (int i = 0; i < b.length; i++)
        {
            b[i] = a[i+start];                        
        }

        sort(b); // Only the substring is sorted
        int bCount = 0; // Added a count so we could print the index of the substring in the next loop.
    
        // This loop prints all the indexes in the arrays. When the index value of start begins, 
        // it prints from array b until after the loop passes the end index value.
        for (int i = 0; i < a.length; i++)
        {
            if (i < start)
            {
                StdOut.print(a[i] + " ");
            }
            else if (i >= start && i <= end)
            {                
                StdOut.print(b[bCount] + " ");
                bCount++;
            }
            else
            {
                StdOut.print(a[i] + " ");
            }
        }
        StdOut.println();
    }
}