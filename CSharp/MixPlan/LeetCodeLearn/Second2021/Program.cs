using System;
using System.Collections.Generic;
using Second2021.Sort;
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
            // TreeNode n2=new TreeNode(6,n5,n6);
            TreeNode n2=new TreeNode(6,n5,null);
            TreeNode n0=new TreeNode(5,n1,n2);

            // N104 n104 = new N104();
            // int depth = n104.MaxDepth(n0);
            // Console.WriteLine($"MaxDepth:{depth}");
            
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

            // N222 n222 = new N222();
            // int res = n222.CountNodes(n0);
            // Console.WriteLine("res::"+res);

            // N257 n257 = new N257();
            // List<string> res= (List<string>)n257.BinaryTreePaths(n0);
            // foreach (string i in res)
            // {
            //     // Console.WriteLine(i+"----");
            //     Console.Write(i+" ");
            // }

            // N404 n404 = new N404();
            // int res = n404.SumOfLeftLeaves(n0);
            // Console.WriteLine("n404 res:"+res);

            // N513 n513 = new N513();
            // int res = n513.FindBottomLeftValue(n0);
            // Console.WriteLine("n513 res:"+res);

            // N112 n112 = new N112();
            // bool res = n112.HasPathSum(n0, 10);
            // Console.WriteLine("n112 res:"+res);

            // N700 n700 = new N700();
            // TreeNode resNode = n700.SearchBST(n0, 1);
            // Console.WriteLine("n700:"+ (resNode==null?999:resNode.val));

            // N98 n98 = new N98();
            // Console.WriteLine("n98:"+n98.IsValidBST(n0));

            // N530 n530 = new N530();
            // Console.WriteLine("N530："+n530.GetMinimumDifference(n0));

            int[] a={30,40,60,10,20,50,70};
            QuickSort sort = new QuickSort();
            sort.QuickSortFun(a);
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

    public class FuncRoot
    {
        public void Func1()
        {
            Console.WriteLine("func1");
        }
    }

    public static class FuncExtension
    {
        public static void FunE1(this FuncRoot funcRoot)
        {
            Console.WriteLine("func E1");
        }
    }
}