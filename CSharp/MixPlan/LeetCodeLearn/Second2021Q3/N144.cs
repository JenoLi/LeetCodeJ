using System.Collections.Generic;
using System.Security.Policy;

namespace Second2021Q3
{
    public class N144
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            List<int> res = new List<int>();
            Func(root, res);
            return res;
        }

        public void Func(TreeNode node, List<int> res)
        {
            //前序 中左右
            if (node == null)
                return;
            res.Add(node.val);
            Func(node.left, res);
            Func(node.right, res);
        }
    }
}