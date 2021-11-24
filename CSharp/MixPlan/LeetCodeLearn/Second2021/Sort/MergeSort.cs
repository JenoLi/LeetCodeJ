using System;

namespace Second2021.Sort
{
    //归并排序 https://www.cnblogs.com/chengxiao/p/6194356.html
    public class MergeSort
    {
        public void MergeSortFun(int[] arr)
        {
            Sort(arr, 0, arr.Length - 1,0);
        }

        private void Sort(int[] arr, int left, int right,int mark)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                Sort(arr, left, mid,1);
                Sort(arr, mid + 1, right,2);
                merge(arr, left, mid, right);
            }
        }

        private void merge(int[] arr, int left, int mid, int right)
        {
            int[] temp = new int[arr.Length];
            int i = left;
            int j = mid + 1;
            int t = 0;
            while (i <= mid && j <= right)
            {
                if (arr[i] < arr[j])
                {
                    temp[t++] = arr[i++];
                }
                else
                {
                    temp[t++] = arr[j++];
                }
            }

            while (i <= mid)
            {
                temp[t++] = arr[i++];
            }

            while (j <= right)
            {
                temp[t++] = arr[j++];
            }

            t = 0;
            while (left <= right)
            {
                arr[left++] = temp[t++];
            }
        }
    }
}