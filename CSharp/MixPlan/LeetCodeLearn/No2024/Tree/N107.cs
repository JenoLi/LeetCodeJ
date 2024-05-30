using System.Collections.Generic;
using No2024.Tree;

namespace No2024.Tree
{
    public class N107
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            List<IList<int>> res = new List<IList<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();

            if (root != null)
                queue.Enqueue(root);

            while (queue.Count > 0)
            {
                List<int> subRes = new List<int>();
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    TreeNode node = queue.Dequeue();
                    subRes.Add(node.val);
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }

                res.Add(subRes);
            }
            res.Reverse();
            return res;
        }
    }
}