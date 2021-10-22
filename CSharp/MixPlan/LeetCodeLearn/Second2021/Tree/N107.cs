using System.Collections.Generic;

namespace Second2021.Tree
{
    public class N107
    {
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
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
                    TreeNode tempNode = queue.Dequeue();
                    tempList.Add(tempNode.val);
                    if(tempNode.left!=null) queue.Enqueue(tempNode.left);
                    if(tempNode.right!=null) queue.Enqueue(tempNode.right);
                }
                res.Add(tempList);
            }
            res.Reverse();
            return res;
        }
    }
}