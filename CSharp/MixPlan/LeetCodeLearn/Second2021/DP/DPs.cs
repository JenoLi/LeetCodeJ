namespace Second2021.DP
{
    public class DPs
    {
        //509. 斐波那契数
        public int Fib(int n) {
            int[] dp=new int[n+1];
            dp[0]=0;
            dp[1]=1;
            for(int i=2;i<=n;i++){
                dp[i]=dp[i-1]+dp[i-2];
            }
            return dp[n];
        }
        
        //746. 使用最小花费爬楼梯
        public int MinCostClimbingStairs(int[] cost) {
            int[] dp=new int[cost.Length];
            dp[0]=cost[0];
            dp[1]=cost[1];
            for(int i=2;i<cost.Length;i++){
                dp[i]=cost[i]+Miner(dp[i-1],dp[i-2]);
            }
            return Miner(dp[cost.Length-1],dp[cost.Length-2]);
        }
        private int Miner(int a,int b){
            return a<b?a:b;
        }
        
        //62. 不同路径
        public int UniquePaths(int m, int n)
        {
            int[][] a = new int[m][]; 
            int[,] dp = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                dp[i, 0] = 1;
            }
            for (int j = 0; j < n; j++)
            {
                dp[0, j] = 1;
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                }
            }

            return dp[m - 1, n - 1];
        }
        
        //343. 整数拆分
        public int IntegerBreak(int n) {
            int[] dp=new int[n+1];
            dp[2]=1;
            for(int i=3;i<=n;i++){
                for(int j=1;j<i-1;j++){
                    dp[i]=Maxer(dp[i],Maxer(j*(i-j),j*dp[i-j]));
                }
            }

            return dp[n];
        }

        private int Maxer(int a,int b){
            return a>b?a:b;
        }
        
    }
}