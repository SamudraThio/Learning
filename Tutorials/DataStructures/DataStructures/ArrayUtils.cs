namespace DataStructures
{
    static class ArrayUtils
    {
        public static void GrowIfNeeded<T>(ref T[] theArray, int requestedIndex)
        {
            if (requestedIndex == theArray.Length)
            {
                int newLength = requestedIndex == 0 ? 1 : requestedIndex * 2;
                T[] tmp = new T[newLength];

                for (int i = 0; i < requestedIndex; i++)
                {
                    tmp[i] = theArray[i];
                }

                theArray = tmp;
            }
        }
    }
}
