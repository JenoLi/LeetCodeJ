namespace Second2021.Tree
{
    public class N100
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            return CompareTree(p, q);
        }
        public bool CompareTree(TreeNode _left,TreeNode _right)
        {
            if (_left == null && _right == null) return true;//都为空
            else if (_left != null && _right == null) return false;//一个为空
            else if (_left == null && _right != null) return false;
            else if (_left.val != _right.val) return false;//不为空但不等
            else//不为空且相等，继续递归
            {
                return CompareTree(_left.left, _right.left) && CompareTree(_left.right, _right.right);
            }
        }
    }
}