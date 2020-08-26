using System;
using System.Collections.Generic;
using System.Security.Authentication;
using System.Text;

namespace SortingClassLibrary
{
    public class InsertionSort:SortingAlgorithms
    {

        public InsertionSort(int size) : base(size) { }

        public override void SortArray()
        {

            InsertionSortArray(base.arr);
        }

        private void InsertionSortArray(int[] arr)
        {
            int n = base.sizeArray;
            //int n = arr.Length;

                for (int i = 1; i < n; ++i)
                {
                    int key = arr[i];
                    int j = i - 1;

                    while (j >= 0 && arr[j] > key)
                    {
                        arr[j + 1] = arr[j];
                        j = j - 1;
                    }
                    arr[j + 1] = key;
                
                 }
        }
    }
}
