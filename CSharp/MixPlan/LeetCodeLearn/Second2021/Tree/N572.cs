namespace Second2021.Tree
{
    public class N572
    {
        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            if (subRoot == null) return true;
            if (root == null) return false;
            //比较root 以及 root的左右子树(递归)
            return Compare(root, subRoot) || IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
        }

        public bool Compare(TreeNode node1, TreeNode node2)
        {
            if (node1 == null && node2 == null) return true;
            else if (node1 != null && node2 == null) return false;
            else if (node1 == null && node2 != null) return false;
            else if (node1.val != node2.val) return false;
            else
            {
                return Compare(node1.left, node2.left) && Compare(node1.right, node2.right);
            }
            
        }
    }
}