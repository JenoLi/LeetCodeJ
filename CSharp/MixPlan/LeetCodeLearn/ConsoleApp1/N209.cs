using System;

namespace First
{
    public class N209
    {
        public int MinSubArrayLen(int s, int[] nums)
        {
            int result = Int32.MaxValue; //窗口长度
            int slowindex = 0; //滑动窗口左端
            int sublength = 0; //子序列长度
            int sum = 0;
            for (int fastindex = 0; fastindex < nums.Length; fastindex++)
            {
                sum += nums[fastindex];
                while (sum >= s)
                {
                    sublength = fastindex - slowindex + 1;
                    result = result < sublength ? result : sublength;
                    sum -= nums[slowindex++];
                }
            }

            return result == Int32.MaxValue ? 0 : result;
        }
    }
}