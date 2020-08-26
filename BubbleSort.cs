using System;
using System.Collections.Generic;
using System.Text;

namespace SortingClassLibrary
{
    public class BubbleSort : SortingAlgorithms
    {
        public BubbleSort(int size) : base(size) { }
        public override void SortArray()
        {
            BubbleSortArray(base.arr);
        }
        private void BubbleSortArray(int[] arr)
        {
            int n = base.sizeArray;
            for (int i = n - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] < arr[j])
                        
                    Exchange(arr, i, j);
                }
            }
        }
    }
}
