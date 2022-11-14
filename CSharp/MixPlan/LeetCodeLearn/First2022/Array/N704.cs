namespace First2022.Array
{
    public class N704
    {
        public int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left<=right)
            {
                int middle = (left + right) / 2;
                if (target < nums[middle])
                {
                    right = middle - 1;
                }else if (target > nums[middle])
                {
                    left = middle + 1;
                }
                else
                {
                    return middle;
                }
            }
            return -1;
        }
    }
}