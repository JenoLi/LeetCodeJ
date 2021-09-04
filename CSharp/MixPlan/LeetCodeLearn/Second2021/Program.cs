using System;
using System.Collections.Generic;

namespace Second2021
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            TreeNode n5=new TreeNode(7,null,null);
            TreeNode n6=new TreeNode(8,null,null);
            TreeNode n3=new TreeNode(1,null,null);
            TreeNode n4=new TreeNode(2,null,null);
            TreeNode n1=new TreeNode(4,n3,n4);
            TreeNode n2=new TreeNode(6,n5,n6);
            TreeNode n0=new TreeNode(5,n1,n2);

            //前序5412678 中序1425768 后序1247865
            N144 n144 = new N144();
            // List<int> res =(List<int>)n144.PreorderTraversal(n0);
            List<int> res =(List<int>)n144.PreorderInteration(n0);
            Console.WriteLine("\n Preorder--");
            foreach (int i in res)
            {
                Console.Write(i+" ");
            }
            
            

            //144
            // N144TreeNode n144TreeNode= new N144TreeNode();
            // List<int> res= (List<int>)n144TreeNode.PreorderTraversal(n0);

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