using System;
using System.Collections.Generic;
using System.Text;

namespace SortingClassLibrary
{
    public class MergeSort : SortingAlgorithms
    { 
        public MergeSort(int size) : base(size) { }

        public override void SortArray()
        {
            int left = 0;
            int right = base.arr.Length - 1;
            MergeSortArray(base.arr, left, right);
        }
        private void MergeSortArray(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = (right + left) / 2;
                MergeSortArray(arr, left, middle);
                MergeSortArray(arr, middle + 1, right);
                Merge(arr, left, middle, right);
            }
        }
        private void Merge(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;
            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int ii = 0; ii < n1; ii++)
                L[ii] = arr[l + ii];
            for (int jj = 0; jj < n2; jj++)
                R[jj] = arr[m + 1 + jj];
            int i = 0;
            int j = 0;
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

    }
}
