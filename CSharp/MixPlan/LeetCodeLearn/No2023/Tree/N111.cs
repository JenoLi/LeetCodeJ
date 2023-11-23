using System.Collections.Generic;

namespace No2023.Tree
{
    public class N111
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null) return 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int mindepth = 0;
            while (queue.Count>0)
            {
                int size = queue.Count;
                mindepth++;
                for (int i = 0; i < size; i++)
                {
                    TreeNode node = queue.Dequeue();
                    if(node.left!=null) queue.Enqueue(node.left);
                    if(node.right!=null) queue.Enqueue(node.right);
                    if (node.left == null && node.right == null)
                        return mindepth;
                }
            }

            return mindepth;
        }
    }
}