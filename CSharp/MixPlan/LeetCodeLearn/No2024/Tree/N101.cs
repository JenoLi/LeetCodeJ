namespace No2024.Tree
{
    public class N101
    {
        //是否对称
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;
            return compare(root.left, root.right);
        }

        private bool compare(TreeNode left, TreeNode right)
        {
            if (left == null && right != null) return false;
            else if (left != null && right == null) return false;
            else if (left == null && right == null) return true;
            else if (left != right) return false;

            bool outside = compare(left.left, right.right);
            bool inside = compare(left.right, right.left);
            return outside && inside;
        }
    }
}