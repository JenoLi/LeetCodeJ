using System.Collections.Generic;

namespace No2024.TreeNo2
{
    public class N02
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            List<IList<int>> res = new List<IList<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            if(root!=null) queue.Enqueue(root);
            while (queue.Count>0)
            {
                int size = queue.Count;
                List<int> subRes = new List<int>();
                
                for (int i = 0; i < size; i++)
                {
                    TreeNode cur = queue.Dequeue();
                    subRes.Add(cur.val);   
                    if(cur.left!=null) queue.Enqueue(cur.left);
                    if(cur.right!=null) queue.Enqueue(cur.right);
                }
                res.Add(subRes);
            }
            
            return res;
        }
    }
}