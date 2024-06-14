using System;
using System.Diagnostics;

namespace No2023.DynamicProgramming
{
    public class N746
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            //dp[i]  到第i阶需要的最小花费
            int dp0 = 0;
            int dp1 = 0;//从1到下一阶才有花费
            for (int i = 2; i <= cost.Length; i++)//<=Length 因为最后的节点取的是i-1，=才能取到数组最后一个
            {
                int dpi = Math.Min(dp0 + cost[i - 2], dp1 + cost[i - 1]);//dp0是前-2节点 对应i-2
                dp0 = dp1;
                dp1 = dpi;
            }

            return dp1;
        } 
    }
}