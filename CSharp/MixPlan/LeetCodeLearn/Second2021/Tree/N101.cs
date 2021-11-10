namespace Second2021.Tree
{
    public class N101
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true; 
            bool isSymmetric = CompareTree(root.left, root.right);
            return isSymmetric;
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
            else return CompareTree(_left.left, _right.right) && CompareTree(_left.right, _right.left);//相等则继续
        }
        
        
    }
}