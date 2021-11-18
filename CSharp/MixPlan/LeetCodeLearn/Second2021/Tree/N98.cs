using System;
using System.Collections.Generic;

namespace Second2021.Tree
{
    public class N98
    {
        public bool IsValidBST(TreeNode root)
        {
            List<int> treeArray = new List<int>();
            Traversal(treeArray,root);
            for (int i = 1; i < treeArray.Count; i++)
            {
                if (treeArray[i] <= treeArray[i - 1])
                    return false;
            }
            return true;
        }

        private void Traversal(List<int> _res,TreeNode _node)
        {
            if (_node == null) return;
            Traversal(_res,_node.left);
            _res.Add(_node.val);
            Traversal(_res,_node.right);
        }
    }
}