namespace No2023.DynamicProgramming
{
    public class TEMP1
    {
        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            int m = obstacleGrid.Length;
            int n = obstacleGrid[0].Length;

            if (obstacleGrid[m - 1][n - 1] == 1 || obstacleGrid[0][0] == 1) //起点终点情况
                return 0;

            int[,] dp = new int[m, n];
            for (int i = 0; i < m && obstacleGrid[i][0] == 0; i++)
                dp[i, 0] = 1;
            for (int i = 0; i < n && obstacleGrid[0][i] == 0; i++)
                dp[0, i] = 1;

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (obstacleGrid[i][j] == 1) continue;
                    dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                }
            }

            return dp[m - 1, n - 1];
        }

        public int UniquePathsWithObstacles2(int[][] obstacleGrid)
        {
            int m = obstacleGrid.Length;
            int n = obstacleGrid[0].Length;

            //起点 终点
            if (obstacleGrid[0][1] == 1 || obstacleGrid[m - 1][n - 1] == 1) return 0;

            //初始化
            int[,] dp = new int[m, n];
            for (int i = 0; i < m && obstacleGrid[i][0] == 0; i++) dp[i, 0] = 1;
            for (int i = 0; i < n && obstacleGrid[0][i] == 0; i++) dp[0, i] = 1;
            //遍历
            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (obstacleGrid[i][j] == 1) continue;
                    dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                }
            }

            return dp[m - 1, n - 1];
        }
    }
}