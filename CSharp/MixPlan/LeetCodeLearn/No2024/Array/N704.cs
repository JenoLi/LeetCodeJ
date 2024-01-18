using System.ComponentModel;

namespace No2023.Array
{
    public class N704
    {
        public int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left<=right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] > target)
                {
                    right = nums[mid - 1];
                }else if (nums[mid] < target)
                {
                    left = nums[mid + 1];
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }
    }
}