using System.Collections.Generic;

namespace Second2021.Tree
{
    public class N513
    {
        public int FindBottomLeftValue(TreeNode root)
        {
            int res = 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            if(root!=null)  queue.Enqueue(root);
            while (queue.Count>0)
            {
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    TreeNode temp = queue.Dequeue();
                    if (i == 0) res = temp.val;
                    if(temp.left!=null) queue.Enqueue(temp.left);
                    if(temp.right!=null) queue.Enqueue(temp.right);
                }
            }
            return res;
        }
    }
}