using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_QuickSort
{
    class Merge_Sort
    {
        public const int MAX = 100;
        private  void Merge(int[] arr, int left, int mid, int right)
        {
            int[] new_arr = new int[MAX];
            int i, left_end, num_elements, tmp_pos;
            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);
            while ((left <= left_end) && (mid <= right))
            {
                if (arr[left] <= arr[mid])
                    new_arr[tmp_pos++] = arr[left++];
                else
                    new_arr[tmp_pos++] = arr[mid++];
            }

            while (left <= left_end)
                new_arr[tmp_pos++] = arr[left++];

            while (mid <= right)
                new_arr[tmp_pos++] = arr[mid++];

            for (i = 0; i < num_elements; i++)
            {
                arr[right] = new_arr[right];
                right--;
            }
        }
        public void MergeSort(int[] arr, int left, int right)
        {
            if (right > left)
            {
                int mid = Convert.ToInt16((left + right) / 2);
                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                Merge(arr, left, mid + 1, right);
            }
        }
    }
}
