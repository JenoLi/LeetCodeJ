namespace First
{
    public class N27
    {
        public int RemoveElement(int[] nums, int val)
        {
            int slowindex = 0;
            for (int fastindex = 0; fastindex < nums.Length; fastindex++)
            {
                if (val != nums[fastindex])
                {
                    nums[slowindex++] = nums[fastindex];
                }
            }
            return slowindex;
        }
    }
}