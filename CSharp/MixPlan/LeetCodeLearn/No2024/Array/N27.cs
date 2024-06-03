namespace No2023.Array
{
    public class N27
    {
        public int RemoveElement(int[] nums, int val)
        {
            int slow = 0;
            for (int fast = 0; fast < nums.Length; fast++)
            {
                if (val != nums[fast])
                    nums[slow++] = nums[fast];
            }
            return slow;
        }
    }
}