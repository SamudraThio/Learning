import java.util.Queue;
import java.util.HashMap;
import java.util.LinkedList;
import java.util.ArrayList;
import java.util.Map;

public class LookupMultipleNumber 
{
    public String key;
    public String value;


    public static void main(String[] args)
    { // Build dictionary, provide values for keys in StdIn.
        In in = new In(args[0]); // Takes in the amino.csv file
        int keyField = Integer.parseInt(args[1]);           
        int valField = Integer.parseInt(args[2]);
        int valField2 = Integer.parseInt(args[3]);
           
        // Make the symbol table
        ST<String, ArrayList<String>> map = new ST<String, ArrayList<String>>();       
        
        // Read in the amino.csv file
        String[] database = in.readAllLines();

        for (int i = 0; i < database.length; i++)
        { // Extract key, value from one line and add to ST.
            String[] tokens = database[i].split(",");
            String key = tokens[keyField];
            String val1 = tokens[valField]; 
            String val2 = tokens[valField2];
            ArrayList<String> val = new ArrayList<String>();
            val.add(val1);
            val.add(val2); 
            map.put(key, val);
        }        
        
        while (!StdIn.isEmpty())
        { // Read key and provide value.
            String s = StdIn.readString();
            if (map.contains(s)) 
            {
                StdOut.println(map.get(s));
            }
            else StdOut.println("Not found");            
        }
    }
} 