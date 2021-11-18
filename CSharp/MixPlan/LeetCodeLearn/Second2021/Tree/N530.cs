using System;
using System.Collections.Generic;

namespace Second2021.Tree
{
    public class N530
    {
        public int GetMinimumDifference(TreeNode root)
        {
            List<int> list = new List<int>();
            int min = Int32.MaxValue;
            Traversal(list, root);
            if (list.Count<=1) return 0;
            for (int i = 1; i < list.Count; i++)
            {
                min = min < (list[i] - list[i - 1]) ? min : (list[i] - list[i - 1]);
            }
            return min;
        }

        private void Traversal(List<int> _list, TreeNode _node)
        {
            if(_node==null) return;
            if(_node.left!=null) Traversal(_list,_node.left);
            _list.Add(_node.val);
            if(_node.right!=null) Traversal(_list,_node.right);
        }
    }
}