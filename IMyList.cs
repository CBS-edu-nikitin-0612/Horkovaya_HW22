using System;
namespace Task2
{
    interface IMyList<T>
    {
        public void Add(T item);
        public int Length { get; }
    }
}