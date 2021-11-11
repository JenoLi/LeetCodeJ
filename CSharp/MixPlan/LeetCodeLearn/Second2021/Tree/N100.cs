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
            if (_left == null && _right != null)//一个空 一个不空
                return false;
            else if (_left != null && _right == null)//一个空 一个不空
                return false;
            else if (_left ==null && _right==null)//都空
                return true;
            else if (_left.val != _right.val)//都不空且不等
                return false;
            else return CompareTree(_left.left, _right.left) && CompareTree(_left.right, _right.right);//相等则继续
        }
    }
}