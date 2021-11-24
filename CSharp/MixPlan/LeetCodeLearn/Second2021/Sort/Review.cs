namespace Second2021.Sort
{
    public class Review
    {
        public void MergeSort(int[] arr)
        {
            Sort(arr,0,arr.Length-1);
        }

        private void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                Sort(arr,left,mid);
                Sort(arr,mid+1,right);
                Merge(arr,left,mid,right);
            }
        }

        private void Merge(int[] arr, int left, int mid, int right)
        {
            int i = left;
            int j = mid+1;
            int t = 0;
            int[] temp = new int[arr.Length];
            while (i<=mid && j<=right)
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

            while (i<=mid)
            {
                temp[t++] = arr[i++];
            }

            while (j<=right)
            {
                temp[t++] = arr[j++];
            }

            t = 0;
            while (left<=right)
            {
                arr[left++] = temp[t++];
            }
        }
    }
}