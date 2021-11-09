using System.Collections.Generic;

namespace Second2021.Tree
{
    public class N226
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return null;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            TreeNode res = new TreeNode();
            queue.Enqueue(root);
            while (queue.Count>0)
            {
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    TreeNode temp = queue.Dequeue();
                    Swap(ref temp.left,ref temp.right);
                    if(temp.left!=null) queue.Enqueue(temp.left);
                    if(temp.right!=null) queue.Enqueue(temp.right);
                }
            }
            return root;
        }

        public void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}