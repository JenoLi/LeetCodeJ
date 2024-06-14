
namespace No2023.DynamicProgramming
{
    public class N70
    {
        public int ClimbStairs(int n)
        {
            if (n <= 2)
                return n;
            int[] dp = new int[n+1];

            dp[0] = 0;//无意义
            dp[1] = 1;
            dp[2] = 2;

            for (int i = 3; i <= n; i++)
            {
                dp[i]= dp[i - 1] + dp[i - 2];
            }
            return dp[n];
        }
    }
}