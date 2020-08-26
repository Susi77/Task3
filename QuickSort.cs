using System;
using System.Collections.Generic;
using System.Text;

namespace SortingClassLibrary
{
    public class QuickSort : SortingAlgorithms
    {
        public QuickSort(int size) : base(size)
        {
        }
        public override void SortArray()
        {
            int left = 0;
            int right = base.arr.Length - 1;
            QucikSortArray(base.arr, left, right);
        }
        private void QucikSortArray(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int pivot = Partition(arr, l, r);
                QucikSortArray(arr, l, pivot);
                QucikSortArray(arr, pivot + 1, r);
            }
        }
        private int Partition(int[] arr, int l, int r)
        {
            int Pivot = arr[l];
            int i = l; int j = r;
            while (true)
            {
                while (arr[i] < Pivot)
                    i++;
                while (arr[j] > Pivot)
                    j--;
                if (i < j)
                {
                    Exchange(arr, i, j);
                    i++;
                    j--;
                }
                else
                {
                    return j;
                }
            }
        }
    }
}
