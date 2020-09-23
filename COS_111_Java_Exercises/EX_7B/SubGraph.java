import java.util.*;
import java.io.*;

public class SubGraph
{
    private ST<String, SET<String>> st;

    public SubGraph()
    { 
        st = new ST<String, SET<String>>(); 
    }

    public int edgeNumber; // number of edges

    public void addEdge(String v, String w)
    { // Put v in w’s SET and w in v’s SET.
        if (!st.contains(v)) 
        {
            st.put(v, new SET<String>());
        }
        if (!st.contains(w)) 
        {
            st.put(w, new SET<String>());
        }
        st.get(v).add(w);
        st.get(w).add(v);
    }

    public boolean hasEdge(String v, String w)
    {
        return st.get(v).contains(w);
    }

    public Iterable<String> adjacentTo(String v)
    { 
        return st.get(v); 
    }

    public Iterable<String> vertices()
    { 
        return st.keys(); 
    }

    public static void main(String[] args)
    { // Read edges from standard input; print resulting graph.
        SubGraph G = new SubGraph();
        System.out.println("The graph is");
        System.out.print(G.toString());

        SubGraph graph = new SubGraph();

        // Mapping the grpah
        for(int i = 1; i < args.length; i++)
        {
            for(int j = 1; j < args.length; j++)
            {
                if(G.hasEdge(args[i], args[j]))
                {
                    graph.addEdge(args[i], args[j]);
                }            
            }
        }

        System.out.println("The subgraph is \n" + graph.toString());
    }
} 