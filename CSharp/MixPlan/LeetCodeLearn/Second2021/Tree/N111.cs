using System.Collections.Generic;

namespace Second2021.Tree
{
    public class N111
    {
        public int MinDepth(TreeNode root)
        {
            int depth = 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            if (root == null) return 0;
            queue.Enqueue(root);
            while (queue.Count>0)
            {
                int size = queue.Count;
                depth++;
                for (int i = 0; i < size; i++)
                {
                    TreeNode node = queue.Dequeue();
                    if(node.left!=null) queue.Enqueue(node.left);
                    if(node.right!=null) queue.Enqueue(node.right);
                    if (node.left == null && node.right == null)
                    {
                        return depth;
                    }
                }
            }
            return depth;
        }
    }
}