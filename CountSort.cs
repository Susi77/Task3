using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingClassLibrary
{
    public class CountSort:SortingAlgorithms
    {
        public CountSort(int size) : base(size) { }

        public override void SortArray()
        {
            CountSortArray(base.arr);
        }
        private void CountSortArray(int[] arr)
        {
            int size = base.sizeArray;
            int maxValueOfArray = arr.Max();
            int[] Count = new int[maxValueOfArray + 1];
            int[] sortedArr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Count[arr[i]]++;
            }
            for (int i = 1; i <= maxValueOfArray; i++)
            {
                Count[i] = Count[i] + Count[i - 1];
            }
            for (int i = size - 1; i >= 0; i--)
            {
                sortedArr[--Count[arr[i]]] = arr[i];
            }
            base.arr = sortedArr;
        }
    }
}
