using System;
using System.Collections.Generic;

namespace First
{
    public class N144TreeNode
    {
        /**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
        
        //迭代
        public IList<int> PreorderTraversal(TreeNode root)
        {
            List<int> result=new List<int>();
            Stack<TreeNode> st=new Stack<TreeNode>();

            if(root!=null) st.Push(root);//根
            
            while (st.Count>0)
            {
                TreeNode node = st.Peek();
                if (node != null)
                {
                    st.Pop();
                    if(node.right!=null) st.Push(node.right);
                    if(node.left!=null) st.Push(node.left);
                    st.Push(node);
                    st.Push(null);
                }
                else
                {
                    st.Pop();
                    node = st.Pop();
                    st.Pop();
                    result.Add(node.val);
                }
            }
            
            return result;

        }
        
        
        //递归-----------------
        // public IList<int> PreorderTraversal(TreeNode root)
        // {
        //     List<int> result=new List<int>();
        //     Traversal(root,result);
        //     return result;
        // }
        //
        // public void Traversal(TreeNode cur, List<int> list)
        // {
        //     if(cur==null) return;
        //     //前序 中左右
        //     list.Add(cur.val);//中
        //     Traversal(cur.left,list);//左
        //     Traversal(cur.right,list);//右
        //     
        //     // //中序 左中右
        //     // Traversal(cur.left,list);//左
        //     // list.Add(cur.val);//中
        //     // Traversal(cur.right,list);//右
        //     //
        //     // //后续 左右中
        //     // Traversal(cur.left,list);//左
        //     // Traversal(cur.right,list);//右
        //     // list.Add(cur.val);//中
        // }

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
}