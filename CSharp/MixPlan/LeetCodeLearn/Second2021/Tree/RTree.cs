using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text.RegularExpressions;

namespace Second2021.Tree
{
    public class RTree
    {
        //深度优先-前序
        public List<int> Preorder01(TreeNode root)
        {
            //递归
            // List<int> result = new List<int>();
            // TraversalPre01(result,root);
            // return result;

            //迭代
            List<int> result = new List<int>();
            Stack<TreeNode> st = new Stack<TreeNode>();
            if (root != null)
                st.Push(root);
            while (st.Count > 0)
            {
                TreeNode temp = st.Pop();
                if (temp != null)
                {
                    if (temp.right != null) st.Push(temp.right);
                    if (temp.left != null) st.Push(temp.left);
                    st.Push(temp);
                    st.Push(null);
                }
                else
                {
                    TreeNode node = st.Pop();
                    result.Add(node.val);
                }
            }

            return result;
        }

        private void TraversalPre01(List<int> res, TreeNode node)
        {
            if (node != null)
            {
                res.Add(node.val);
            }

            if (node.left != null) TraversalPre01(res, node.left);
            if (node.right != null) TraversalPre01(res, node.right);
        }

        //层序遍历
        public List<List<int>> LevelOrder(TreeNode node)
        {
            List<List<int>> result = new List<List<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            if (node != null)
                queue.Enqueue(node);
            while (queue.Count > 0)
            {
                int size = queue.Count;
                List<int> sublist = new List<int>();
                for (int i = 0; i < size; i++)
                {
                    TreeNode temp = queue.Dequeue();
                    sublist.Add(temp.val);
                    if (temp.left != null) queue.Enqueue(temp.left);
                    if (temp.right != null) queue.Enqueue(temp.right);
                }

                result.Add(sublist);
            }

            return result;
        }

        //107 自底向上
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            List<IList<int>> result = new List<IList<int>>();
            if (root != null)
                queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int size = queue.Count;
                List<int> templist = new List<int>();
                for (int i = 0; i < size; i++)
                {
                    TreeNode temp = queue.Dequeue();
                    templist.Add(temp.val);
                    if (temp.left != null) queue.Enqueue(temp.left);
                    if (temp.right != null) queue.Enqueue(temp.right);
                }

                result.Add(templist);
            }

            result.Reverse();
            return result;
        }

        //199 二叉树右视图
        public IList<int> RightSideView(TreeNode root)
        {
            List<int> result = new List<int>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            if (root != null)
                queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    TreeNode temp = queue.Dequeue();
                    if (i == size - 1)
                    {
                        result.Add(temp.val);
                    }

                    if (temp.left != null) queue.Enqueue(temp.left);
                    if (temp.right != null) queue.Enqueue(temp.right);
                }
            }

            return result;
        }

        //637 层平均值
        public IList<double> AverageOfLevels(TreeNode root)
        {
            List<double> result = new List<double>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            if (root != null)
                queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int size = queue.Count;
                double sum = 0;
                for (int i = 0; i < size; i++)
                {
                    TreeNode temp = queue.Dequeue();
                    sum += temp.val;
                    if (temp.left != null) queue.Enqueue(temp.left);
                    if (temp.right != null) queue.Enqueue(temp.right);
                }

                result.Add(sum / size);
            }

            return result;
        }
        // 429.N叉树的层序遍历
        // public IList<IList<int>> LevelOrder(Node root) {
        //     List<IList<int>> result=new List<IList<int>>();
        //     Queue<Node> queue=new Queue<Node>();
        //     if(root!=null)
        //         queue.Enqueue(root);
        //     while(queue.Count>0){
        //         int size=queue.Count;
        //         List<int> subList=new List<int>();
        //         for(int i=0;i<size;i++){
        //             Node temp=queue.Dequeue();
        //             subList.Add(temp.val);
        //             for(int j=0;j<temp.children.Count;j++){
        //                 if(temp.children[j]!=null){
        //                     queue.Enqueue(temp.children[j]);
        //                 }
        //             }
        //         }
        //         result.Add(subList);
        //     }
        //     return result;
        // }

        //515. 在每个树行中找最大值
        public IList<int> LargestValues(TreeNode root)
        {
            List<int> result = new List<int>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            if (root != null)
                queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int size = queue.Count;
                int max = 0;
                for (int i = 0; i < size; i++)
                {
                    TreeNode temp = queue.Dequeue();
                    if (i == 0)
                        max = temp.val;
                    if (max < temp.val)
                    {
                        max = temp.val;
                    }

                    if (temp.left != null) queue.Enqueue(temp.left);
                    if (temp.right != null) queue.Enqueue(temp.right);
                }

                result.Add(max);
            }

            return result;
        }

        public Node Connect(Node root)
        {
            Queue<Node> queue = new Queue<Node>();
            if (root != null) queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int size = queue.Count;
                Node pre = null;
                for (int i = 0; i < size; i++)
                {
                    Node temp = queue.Dequeue();
                    if (i == 0)
                    {
                        pre = temp;
                    }
                    else
                    {
                        pre.next = temp;
                        pre = pre.next;
                    }

                    if (temp.left != null) queue.Enqueue(temp.left);
                    if (temp.right != null) queue.Enqueue(temp.right);
                }

                pre.next = null;
            }

            return root;
        }

        //110. 平衡二叉树
        public bool IsBalanced(TreeNode root)
        {
            if (GetDepth(root) == -1)
                return false;
            return true;
        }

        private int GetDepth(TreeNode node)
        {
            if (node == null)
                return 0;
            int leftDepth = GetDepth(node.left);
            if (leftDepth == -1) return -1;
            int rigthDepth = GetDepth(node.right);
            if (rigthDepth == -1) return -1;

            int result;
            if (Math.Abs(leftDepth - rigthDepth) > 1)
            {
                result = -1;
            }
            else
            {
                int max = leftDepth > rigthDepth ? leftDepth : rigthDepth;
                result = 1 + max;
            }

            return result;
        }

        //257. 二叉树的所有路径 
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            List<int> path = new List<int>();
            List<string> result = new List<string>();
            Traversal(root, path, result);
            return result;
        }
        //前序遍历 中左右
        private void Traversal(TreeNode node, List<int> path, List<string> res)
        {
            path.Add(node.val); //记录线路
            if (node.left == null && node.right == null)
            {
                //拼接
                int size = path.Count;
                string temp = "";
                for (int i = 0; i < size - 1; i++)
                {
                    temp += path[i] + "->";
                }
                temp += path[size - 1].ToString();
                res.Add(temp);
            }

            //递归
            if (node.left != null)
            {
                Traversal(node.left, path, res);
                path.RemoveAt(path.Count - 1);
            }

            if (node.right != null)
            {
                Traversal(node.right, path, res);
                path.RemoveAt(path.Count - 1);
            }
        }
        public int SumOfLeftLeaves(TreeNode root) {
            Stack<TreeNode> st=new Stack<TreeNode>();
            if(root!=null) st.Push(root);
            int sum = 0;
            while (st.Count>0)
            {
                TreeNode temp = st.Pop();
                if (temp.left != null && temp.left.left == null && temp.left.right == null)
                {
                    sum += temp.left.val;
                }
                
                if(temp.right!=null) st.Push(temp.right);
                if(temp.left!=null) st.Push(temp.left);
            }
            return sum;
        }
    }
    // public class Node {
    //     public int val;
    //     public IList<Node> children;
    //
    //     public Node() {}
    //
    //     public Node(int _val) {
    //         val = _val;
    //     }
    //
    //     public Node(int _val, IList<Node> _children) {
    //         val = _val;
    //         children = _children;
    //     }
    // }
}

public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node()
        {
        }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }