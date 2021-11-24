using System;

//快速排序 参考https://www.cnblogs.com/skywang12345/p/3596746.html
namespace Second2021.Sort
{
    public class QuickSort
    {
        public int[] QuickSortFun(int[] args)
        {
            Sort(args, 0, args.Length - 1);
            return args;
        }

        private void Sort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int i = low;
                int j = high;
                int temp = arr[low];
                while (i < j)
                {
                    //从右侧开始，小于标准时，放到左边
                    while (i < j && arr[j] > temp)
                    {
                        j--;
                    }
                    arr[i] = arr[j];
                    
                    //遍历左侧，大于标准时，放到右边
                    while (i < j && arr[i] < temp)
                    {
                        i++;
                    }
                    arr[j] = arr[i];
                }

                //i==j时，赋值标准值
                arr[i] = temp;
                //递归左半边 和  右半边
                Sort(arr, low,i-1);
                Sort(arr, i+1,high);
            }
        }
    }
}