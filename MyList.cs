using System;
namespace Task2
{
    class MyList<T>: IMyList<T>
    {
        private T[] arr;
        public int Length { get; private set; }
        public T this[int index]
        {
            get => arr[index];
            set => arr[index] = value;
        }
        public MyList()
        {
            arr = new T[0];
            Length = 0;
        }
        public void Add(T item)
        {
            T[] arrX = new T[Length + 1];
            for (int i = 0; i < Length; i++)
            {
                arrX[i] = arr[i];
            }
            arrX[Length] = item;
            arr = arrX;
            Length++;
        }
    }
}