using System;
using System.Collections;
using System.Collections.Generic;

namespace First
{
    public class N102
    {
        //二叉树层序遍历
        public IList<IList<int>> LevelOrder(TreeNode root) {
            IList<IList<int>> result=new List<IList<int>>();
            Queue<TreeNode> queue=new Queue<TreeNode>();
            if(root!=null) queue.Enqueue(root);
            while (queue.Count>0)
            {
                int size = queue.Count;
                List<int> templist=new List<int>();
                Console.WriteLine("size:"+size);
                for (int i = 0; i < size; i++)
                {
                    TreeNode node = queue.Dequeue();
                    if(node!=null) templist.Add(node.val);
                    
                    if(node.left!=null) queue.Enqueue(node.left);
                    if(node.right!=null) queue.Enqueue(node.right);
                }
                result.Add(templist);
            }
            return result;
        }
    }
}