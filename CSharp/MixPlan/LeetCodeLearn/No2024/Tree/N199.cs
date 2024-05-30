using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace No2024.Tree
{
    public class N199
    {
        public IList<int> rightSideView(TreeNode root)
        {
            List<int> res = new List<int>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            if(root!=null)
                queue.Enqueue(root);
            while (queue.Count>0)
            {
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    TreeNode temp = queue.Dequeue();
                    if(i==size-1)
                        res.Add(temp.val);
                    if(temp.left!=null) queue.Enqueue(temp.left);
                    if(temp.right!=null) queue.Enqueue(temp.right);
                }
            }
            return res;
        }
    }
}