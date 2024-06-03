namespace No2023.Array
{
    public class N26
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 1)
                return 1;
            int slow = 1;
            int val = nums[0];
            for (int fast = 1; fast < nums.Length; fast++)
            {
                if (val != nums[fast])
                {
                    nums[slow++] = nums[fast];
                }

                val = nums[fast];
            }

            return slow;
        }
    }
}