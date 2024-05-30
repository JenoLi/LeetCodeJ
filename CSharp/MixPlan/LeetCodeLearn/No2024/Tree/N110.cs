using System;

namespace No2024.Tree
{
    public class N110
    {
        public bool IsBalance(TreeNode node)
        {
            int depth = GetDepth(node);
            return depth == -1 ? false : true;
        }

        public int GetDepth(TreeNode node)
        {
            if (node == null) return -1;
            int left = GetDepth(node.left);
            if (left == -1) return -1;
            int right = GetDepth(node.right);
            if (right == -1) return -1;

            int res = 0;
            if (Math.Abs(left - right) > 1)
                res = -1;
            else
            {
                res = 1 + Math.Max(left, right);
            }

            return res;
        }
    }
}