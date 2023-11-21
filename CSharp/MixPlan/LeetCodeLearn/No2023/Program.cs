using System;
using System.Collections.Generic;
using No2023.Tree;

namespace No2023
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
            // TreeNode n2=new TreeNode(6,n5,null);
            TreeNode n0=new TreeNode(5,n1,n2);

            // N107 n107 = new N107();
            // IList<IList<int>> res= n107.LevelOrder(n0);
            // foreach (IList<int> list in res)
            // {
            //     foreach (int i in list)
            //     {
            //         Console.Write(i);
            //     }
            //     Console.WriteLine("---------");
            // }

            N199 n199 = new N199();
            IList<int> res = n199.rightSideView(n0);
            foreach (int i in res)
            {
                Console.Write(i);
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