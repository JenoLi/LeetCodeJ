using System;
using System.Collections.Generic;
using Second2021.Tree;

namespace Second2021
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //         5
            //     4       6
            // 1      2  7     8

            TreeNode n5=new TreeNode(7,null,null);
            TreeNode n6=new TreeNode(8,null,null);
            TreeNode n3=new TreeNode(1,null,null);
            TreeNode n4=new TreeNode(2,null,null);
            TreeNode n1=new TreeNode(4,n3,n4);
            TreeNode n2=new TreeNode(6,n5,n6);
            TreeNode n0=new TreeNode(5,n1,n2);

            N104 n104 = new N104();
            int depth = n104.MaxDepth(n0);
            Console.WriteLine($"MaxDepth:{depth}");
            
            // N111 n111 = new N111();
            // int minDepth = n111.MinDepth(n0);
            // Console.WriteLine($"MinDepth:{minDepth}");

            //前序5412678 中序1425768 后序1247865
            // Console.WriteLine("\n Preorder--");
            // N144 n144 = new N144();
            // List<int> res =(List<int>)n144.PreorderTraversal(n0);
            // List<int> res =(List<int>)n144.PreorderInteration(n0);
            // Console.WriteLine("\n Postorder--");
            // N94 n94 = new N94();
            // List<int> res =(List<int>)n94.PostorderInteration(n0);
            // foreach (int i in res)
            // {
            //     Console.Write(i+" ");
            // }



            // Console.WriteLine("层序遍历 LevelOrder");
            // N102 n102 = new N102();
            // IList<IList<int>> res =n102.LevelOrder(n0);
            
            // Console.WriteLine("反向层序遍历 LevelOrderBottom");
            // N107 n107 = new N107();
            // IList<IList<int>> res =n107.LevelOrderBottom(n0);
            //
            // foreach (List<int> i in res)
            // {
            //     // Console.WriteLine(i+"----");
            //     for (int j = 0; j < i.Count; j++)
            //     {
            //         Console.Write(i[j]+" ");
            //     }
            //     Console.WriteLine();
            // }

            //144
            // N144TreeNode n144TreeNode= new N144TreeNode();
            // List<int> res= (List<int>)n144TreeNode.PreorderTraversal(n0);
            
            // Console.WriteLine("RightSideView");
            // N199 n199 = new N199();
            // IList<int> res =n199.RightSideView(n0);
            //
            // foreach (int i in res)
            // {
            //     // Console.WriteLine(i+"----");
            //     Console.Write(i+" ");
            // }

            // N226 n226 = new N226();
            // TreeNode res= n226.InvertTree(n0);
            

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