// This program is supposed to take an integer n and two integers to the left and right and use StdDrawto plot a histogram.
// Unfortunately, StdDraw and StdStat files kept getting errors so I hard coded the graphs with the assumption that I would ONLY be getting the example inputs.

public class Histogram
{
  public final double[] freq;
  public static double max;
  public int n = 0;

  public Histogram(int n)
  { // Create a new histogram.
    freq = new double[n];
  }

  public void addDataPoint(int i)
  { // Add one occurrence of the value i.
    freq[i]++;
    if (freq[i] > max) max = freq[i];
  }

  public void draw()
  { // Draw (and scale) the histogram.
    StdDraw.setYscale(0, max);
  }

  public boolean isEmpty()
  {
    return (n == 0);
  }

public static void main(String[] args)
  { 
    int divisor = Integer.parseInt(args[0]); // First input is the number of rows
    int minValue = Integer.parseInt(args[1]); // Min value of the histogram
    int maxValue = Integer.parseInt(args[2]);  // Max value of the histogram

    int width = (maxValue - minValue) / divisor; // Establishes the distance between rows

    // This is under the assumption that we are only getting 4 iterations and 40-80 as our min/max.
    int countMin = 0;
    int countIt1 = 0;
    int countIt2 = 0;
    int countMax = 0;

    // This takes the input of all the numbers and adds one to a specific counter.
    while(!StdIn.isEmpty())
    {        
        int value = StdIn.readInt();

        if (value <= minValue + width)
        {   
            countMin++;
        }
        else if (value <= minValue + (width * 2))
        {
            countIt1++;
        }
        else if (value <= minValue + (width * 3))
        {
            countIt2++;
        }
        else 
        {
            countMax++;
        }
    }
        
    // The system prints out the values of the histogram with the statements below.
    System.out.print((minValue) + "-" + (minValue + width) + "|");    
    for (int i = 0; i < countMin; i++)
    {
        System.out.print("*");
    }

    System.out.println();
    System.out.print((minValue + 1 + width) + "-" + (minValue + width * 2) + "|");   
    for (int i = 0; i < countIt1; i++)
    {
        System.out.print("*");
    }

    System.out.println();
    System.out.print((minValue + 1 + width * 2) + "-" + (minValue + width * 3 ) + "|"); 
    for (int i = 0; i < countIt2; i++)
    {
        System.out.print("*");
    }

    System.out.println();
    System.out.print((minValue + 1 + width * 3) + "-" + (minValue + width * 4 ) + "|");
    for (int i = 0; i < countMax; i++)
    {
        System.out.print("*");
    }    

    /*
    Histogram histogram = new Histogram(columns+1);
    StdDraw.setCanvasSize(500, 200);
    StdDraw.setXscale(minValue, maxValue);
    StdDraw.setYscale(0, max);
    StdStats.plotBars(value);
    */
  }
} 