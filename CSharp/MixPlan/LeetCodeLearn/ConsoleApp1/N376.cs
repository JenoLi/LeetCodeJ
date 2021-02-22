using System;

namespace First
{
    public class N376
    {
        public int WiggleMaxLength(int[] nums)
        {
            if (nums.Length <= 1)
                return nums.Length;
            int result = 1;
            int pre = 0;//前一个差值
            int cur = 0;//当前差值
            for (int i = 1; i < nums.Length; i++)
            {
                cur = nums[i] - nums[i-1];
                Console.WriteLine("cur:"+cur+" pre:"+pre);
                if ((pre <= 0 && cur > 0)|| (pre>=0 && cur<0))
                {
                    Console.WriteLine("+");
                    result++;
                    pre = cur;
                }
            }
            return result;


        }
    }
}