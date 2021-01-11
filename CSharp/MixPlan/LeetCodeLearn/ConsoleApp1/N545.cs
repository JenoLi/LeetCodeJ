using System.Collections;
using System.Collections.Generic;

namespace First
{
    public class N545
    {
        public IList<int> BoundaryOfBinaryTree(TreeNode root)
        {
           List<int> res=new List<int>();
           if (root == null)
               return res;
           if (!isLeaf(root))
           {
               res.Add(root.val);
           }

           TreeNode t = root.left;
           while (t!=null)
           {
               if (!isLeaf(t))
               {
                   res.Add(t.val);
               }

               if (t.left != null)
               {
                   t = t.left;
               }
               else
               {
                   t = t.right;
               }
           }
           addLeaves(res, root);
           
           //右边界
           Stack<int> s = new Stack<int>();
           t = root.right;
           while (t != null) {
               if (!isLeaf(t)) {
                   s.Push(t.val);
               }
               if (t.right != null) {
                   t = t.right;
               } else {
                   t = t.left;
               }
           }
           while (!(s.Count<=0)) {
               res.Add(s.Pop());
           }
           
           return res;
        }
        
        public bool isLeaf(TreeNode t)
        {
            return t.left == null && t.right == null;
        }

        public void addLeaves(List<int> res, TreeNode root)
        {
            if (isLeaf(root))
            {
                res.Add(root.val);
            }else {
                if (root.left != null) {
                    addLeaves(res, root.left);
                }
                if (root.right != null) {
                    addLeaves(res, root.right);
                }
            }
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}