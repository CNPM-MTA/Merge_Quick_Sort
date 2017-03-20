using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_QuickSort
{
    class Quick_Sort
    {
        public void QuickSort(int[] arr, int left, int right)
        {
            if (left >= right) return;
            int i = Partition(arr, left, right);
            QuickSort(arr, left, i - 1);
            QuickSort(arr, i + 1, right);

        }
        private int Partition(int[] arr, int left, int right)
        {
            int x = arr[left];
            int i = left + 1;
            int j = right;
            while (i < j)
            {
                while (i < j && arr[i] < x) i++;
                while (j >= i && arr[j] >= x) j--;
                if (i < j) Swap(ref arr[i], ref arr[j]);
            }
            Swap(ref arr[left], ref arr[j]);
            return j;
        }
        private void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
    }
}
