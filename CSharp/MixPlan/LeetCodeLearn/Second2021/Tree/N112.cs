using System;

namespace Second2021.Tree
{
    public class N112
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null) return false;
            return Traversal(root,targetSum-root.val);
        }

        private bool Traversal(TreeNode _node, int _count)
        {
            if (_node.left == null && _node.right == null && _count == 0) return true;
            if (_node.left == null && _node.right == null && _count != 0) return false;

            if (_node.left != null)
            {
                _count -= _node.left.val;
                if (Traversal(_node.left, _count)) return true;
                _count += _node.left.val;
            }
            if (_node.right != null)
            {
                _count -= _node.right.val;
                if (Traversal(_node.right, _count)) return true;
                _count += _node.right.val;
            }

            return false;
        }
        

        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    }
}