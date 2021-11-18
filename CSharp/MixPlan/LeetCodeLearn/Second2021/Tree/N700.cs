using System;

namespace Second2021.Tree
{
    public class N700
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null || root.val == val) return root;
            if (root.val > val) return SearchBST(root.left, val);//及时返回结果
            if (root.val < val) return SearchBST(root.right, val);
            return null;
        }
    }
}