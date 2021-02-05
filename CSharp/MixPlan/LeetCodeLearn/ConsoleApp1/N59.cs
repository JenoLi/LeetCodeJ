namespace First
{
    public class N59
    {
        public int[][] GenerateMatrix(int n)
        {
            int[][] mat = new int[n][];
            for (int i = 0; i < n; i++)
            {
                mat[i] = new int[n];
            }

            int L = 0, T = 0; //左 上边界
            int B = n - 1, R = n - 1; //下 右边界
            int tar = n * n; //总数
            int num = 1; //当前数
            while (num <= tar)
            {
                for (int i = L; i <= R; i++)
                    mat[T][i] = num++;
                T++;
                for (int i = T; i <= B; i++)
                    mat[i][R] = num++;
                R--;
                for (int i = R; i >= L; i--)
                    mat[B][i] = num++;
                B--;
                for (int i = B; i >= T; i--)
                    mat[i][L] = num++;
                L++;
            }
            return mat;
        }
    }
}