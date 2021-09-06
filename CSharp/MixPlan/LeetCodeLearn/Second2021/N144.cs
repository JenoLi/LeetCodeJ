using System;
using System.Collections.Generic;
using System.Security.Policy;

namespace Second2021
{
    //前序
    public class N144
    {
        public IList<int> PreorderTraversal(TreeNode node)
        {
            List<int> res = new List<int>();
            FuncPreorder(res, node);
            return res;
        }

        public void FuncPreorder(List<int> res, TreeNode node)
        {
            if (node == null) return;
            res.Add(node.val);
            FuncPreorder(res, node.left);
            FuncPreorder(res, node.right);
        }

        //迭代：栈+标记  入栈顺序：前序：右左中
        public IList<int> PreorderInteration(TreeNode node)
        {
            List<int> res = new List<int>();
            Stack<TreeNode> st = new Stack<TreeNode>();
            if (node != null)
            {
                st.Push(node);
            }
            while (st.Count > 0)
            {
                TreeNode tempNode = st.Peek();
                if (tempNode != null)
                {
                    st.Pop();
                    if (tempNode.right != null) st.Push(tempNode.right);
                    if (tempNode.left != null) st.Push(tempNode.left);
                    st.Push(tempNode);
                    st.Push(null);
                }
                else
                {
                    st.Pop();
                    tempNode = st.Pop();
                    res.Add(tempNode.val);
                }
            }
            return res;
        }
    }
    
    //中序
    public class N145
    {
        public IList<int> InorderTraversal(TreeNode node)
        {
            List<int> res = new List<int>();
            Inorder(res, node);
            return res;
        }

        public void Inorder(List<int> _res, TreeNode _node)
        {
            if (_node == null) return;
            Inorder(_res, _node.left);
            Inorder(_res, _node.right);
            _res.Add(_node.val);
        }
    }
    
    //后序 
    public class N94
    {
        public IList<int> PostorderTraversal(TreeNode node)
        {
            List<int> res = new List<int>();
            Postorder(res, node);
            return res;
        }

        public void Postorder(List<int> res, TreeNode node)
        {
            if (node == null) return;
            Postorder(res, node.right);
            res.Add(node.val);
            Postorder(res, node.left);
        }
    }

    // public class N102
    // {
    //     //层序遍历
    //     public IList<List<int>> LevelOrder(TreeNode node)
    //     {
    //         List<List<int>> res = new List<List<int>>();
    //         Queue<TreeNode> queue = new Queue<TreeNode>();
    //         if (node != null)
    //         {
    //             queue.Enqueue(node);
    //         }
    //
    //         while (queue.Count>0)
    //         {
    //             int size = queue.Count;
    //             List<int> tempRes = new List<int>();
    //             Console.WriteLine("size:"+size);
    //             for (int i = 0; i < size; i++)
    //             {
    //                 TreeNode tempNode = queue.Dequeue();
    //                 if(tempNode!=null) tempRes.Add(tempNode.val);
    //                 Console.WriteLine("val:"+tempNode.val);
    //                 if(tempNode.left!=null) queue.Enqueue(tempNode.left);
    //                 if(tempNode.right!=null) queue.Enqueue(tempNode.right);
    //             }
    //             res.Add(tempRes);
    //         }
    //         return res;
    //     }
    // }


}