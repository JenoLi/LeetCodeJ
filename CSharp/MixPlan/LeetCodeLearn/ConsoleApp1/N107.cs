using System;
using System.Collections.Generic;
using System.Linq;

namespace First
{
    public class N107
    {
        //二叉树层序遍历II
        public IList<IList<int>> LevelOrderBottom(TreeNode root) {
            IList<IList<int>> result=new List<IList<int>>();
            Queue<TreeNode> queue=new Queue<TreeNode>();
            if(root!=null) queue.Enqueue(root);
            while (queue.Count>0)
            {
                int size = queue.Count;
                List<int> templist=new List<int>();
                for (int i = 0; i < size; i++)
                {
                    TreeNode node = queue.Dequeue();
                    if(node!=null) templist.Add(node.val);
                    
                    if(node.left!=null) queue.Enqueue(node.left);
                    if(node.right!=null) queue.Enqueue(node.right);
                }
                result.Add(templist);
            }
            result.Reverse();
            return result;
        }
    }
}