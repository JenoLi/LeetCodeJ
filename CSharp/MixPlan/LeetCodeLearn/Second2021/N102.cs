using System.Collections.Generic;

namespace Second2021
{
    public class N102
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            List<IList<int>> res = new List<IList<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            if(root!=null) queue.Enqueue(root);
            while (queue.Count>0)
            {
                int size = queue.Count;
                List<int> tempList = new List<int>();
                for (int i = 0; i < size; i++)
                {
                    TreeNode node = queue.Dequeue();
                    if(node!=null) tempList.Add(node.val);
                    if(node.left!=null) queue.Enqueue(node.left);
                    if(node.right!=null) queue.Enqueue(node.right);
                }
                res.Add(tempList);
            }
            return res;
        }

    }
}