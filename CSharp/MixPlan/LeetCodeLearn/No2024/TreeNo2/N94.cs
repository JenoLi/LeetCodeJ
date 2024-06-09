using System.Collections.Generic;

namespace No2024.TreeNo2
{
    public class N94
    {
        //中序 递归  左中右
        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> res = new List<int>();
            Traversal(root,res);
            return res;
        }

        private void Traversal(TreeNode node, List<int> list)
        {
            if(node==null) return;
            Traversal(node.left,list);//D
            list.Add(node.val);       //H
            Traversal(node.right,list);
        }
    }
}