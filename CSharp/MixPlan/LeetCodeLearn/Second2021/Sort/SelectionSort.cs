using System;

namespace Second2021.Sort
{
    public class SelectionSort
    {
        //两次遍历，选择小的放在前面
        public void SelectionSortFun(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                int min = i;
                int temp = 0;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
            }
        }
    }
}