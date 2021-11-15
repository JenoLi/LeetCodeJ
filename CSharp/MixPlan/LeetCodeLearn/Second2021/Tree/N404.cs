using System;
using System.Collections.Generic;

namespace Second2021.Tree
{
    public class N404
    {
        public int SumOfLeftLeaves(TreeNode root)
        {
            int res = 0;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            if(root!=null) stack.Push(root);
            while (stack.Count>0)
            {
                TreeNode temp = stack.Pop();
                if (temp.left != null && temp.left.left == null && temp.left.right == null)
                {
                    res += temp.left.val;
                    Console.WriteLine("leave:"+temp.left.val);
                }
                if(temp.left!=null) stack.Push(temp.left);
                if(temp.right!=null) stack.Push(temp.right);
            }
            return res;
        }
//mid left right
        public List<int> Pre(TreeNode root)
        {
            List<int> res = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            if(root!=null) stack.Push(root);
            while (stack.Count>0)
            {
                TreeNode temp = stack.Pop();
                if (temp != null)
                {
                    if(temp.right!=null) stack.Push(temp.right);
                    if(temp.left!=null) stack.Push(temp.left);
                    
                    stack.Push(temp);
                    stack.Push(null);
                }
                else
                {
                    res.Add(temp.val);
                }
            }

            return res;
        }
    }
}