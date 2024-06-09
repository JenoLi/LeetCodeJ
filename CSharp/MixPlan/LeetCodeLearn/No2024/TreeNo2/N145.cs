using System.Collections.Generic;

namespace No2024.TreeNo2
{
    public class N145
    {
        //后续遍历 递归
        public IList<int> PostorderTraversal(TreeNode root)
        {
            List<int> res = new List<int>();
            Traversal(root,res);
            return res;
        }

        private void Traversal(TreeNode node, List<int> list)
        {
            if(node==null) return;
            Traversal(node.left,list);
            Traversal(node.right,list);
            list.Add(node.val);
        }
    }
}