namespace DataStructures
{
    class MyList<T>
    {
        T[] backingStore = new T[0];
        public int Length { get; private set; } = 0;

        public T this[int index]
        {
            get => GetValueAtIndex(index);
            set => InsertAt(index, value);
        }


        public void InsertAt(int index, T newValue)
        {
            // Check to make sure another value will fit
            ArrayUtils.GrowIfNeeded(ref backingStore, Length);

            // Insert the new element to the list
            backingStore[index] = newValue;
            Length += 1;

        }
        public void InsertAtEnd(T newValue) => InsertAt(Length, newValue);
        public T GetValueAtIndex(int index) => backingStore[index];
    }
}
