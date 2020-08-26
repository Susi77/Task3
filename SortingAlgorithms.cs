using System;

namespace SortingClassLibrary
{
    abstract public class SortingAlgorithms
    {
        protected int[] arr;
        protected int sizeArray;

        public SortingAlgorithms(int size)
        {
            sizeArray = size;
            arr = new int[sizeArray];
        }
        public void FillArray()
        {
            int Min = 10;
            int Max = 100;
            Random randNum = new Random();
            for (int i = 0; i < sizeArray; i++)
            {
                arr[i] = randNum.Next(Min, Max);
            }
        }
        public int[] GetSortedArray { get { return arr; } }
        public abstract void SortArray();
        public virtual void Exchange(int[] arr, int i, int j)
        {
            int temp;
            temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}

