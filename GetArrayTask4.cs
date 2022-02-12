using System;
namespace Task2
{
    static class GetArrayTask4
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] arrX = new T[list.Length];
            for (int i = 0; i < arrX.Length; i++)
            {
                arrX[i] = list[i];
            }
            return arrX;
        }
    }
}