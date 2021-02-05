namespace First
{
    public class N35
    {
        public int SearchInsert(int[] nums, int target)
        {
            if (nums.Length == 0 || target < nums[0])
            {
                return 0;
            }

            int left = 0;
            int right = nums.Length-1;
            while (left <= right)
            {
                int middle = (right + left) / 2;
                if (nums[middle] > target)
                {
                    right = middle - 1;
                }
                else if (nums[middle] < target)
                {
                    left = middle + 1;
                }
                else
                {
                    return middle;
                }
            }

            return right + 1;
        }
    }
}