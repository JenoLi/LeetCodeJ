using System;
using System.Collections.Generic;

namespace Second2021Q3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            TreeNode n3=new TreeNode(1,null,null);
            TreeNode n4=new TreeNode(2,null,null);
            TreeNode n1=new TreeNode(4,n3,n4);
            TreeNode n2=new TreeNode(6,null,null);
            TreeNode n0=new TreeNode(5,n1,n2);

            N144 n144 = new N144();
            List<int> res =(List<int>)n144.PreorderTraversal(n0);

            foreach (int i in res)
            {
                Console.WriteLine(i);
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