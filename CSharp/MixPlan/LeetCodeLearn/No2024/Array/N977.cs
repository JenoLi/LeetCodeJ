namespace No2023.Array
{
    public class N977
    {
        public int[] SortedSquares(int[] nums)
        {
            int k = nums.Length-1;
            int[] res = new int[nums.Length];
            int left = 0;
            int right = nums.Length - 1;
            while (left<=right)
            {
                int L2 = nums[left] * nums[left];
                int R2 = nums[right] * nums[right];
                if (L2 < R2)
                {
                    right--;
                    res[k--] = R2;
                }
                else
                {
                    left++;
                    res[k--] = L2;
                }
            }

            return res;
        }
    }
}