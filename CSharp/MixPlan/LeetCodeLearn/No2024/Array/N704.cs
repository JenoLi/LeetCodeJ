
namespace No2023.Array
{
    public class N704
    {
        public int Search(int[] nums, int target)
        {
            int indexL = 0;
            int indexR = nums.Length-1;
            while (indexL<=indexR)
            {
                int indexM = (indexL + indexR) / 2;
                if (target>nums[indexM])
                {
                    indexL = indexM+1;
                }else if (target < nums[indexM])
                {
                    indexR = indexM-1;
                }
                else
                {
                    return indexM;
                }
            }
            return -1;
        }
    }
}