using System.Collections.Generic;
using System.Security.Policy;

namespace No2024.Tree
{
    public class N144
    {
        //中序 右中左
        public IList<int> InorderInteration(TreeNode root)
        {
            List<int> res = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            if(root!=null)
                stack.Push(root);
            while (stack.Count>0)
            {
                TreeNode temp = stack.Pop();
                if (temp != null)
                {
                    if(temp.right!=null) stack.Push(temp.right);
                    stack.Push(temp);
                    stack.Push(null);
                    if(temp.left!=null) stack.Push(temp.left);
                }
                else
                {
                    res.Add(stack.Pop().val);
                }
            }

            return res;
        }
    }
}