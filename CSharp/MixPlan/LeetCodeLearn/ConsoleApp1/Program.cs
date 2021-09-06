using System;
using System.Collections.Generic;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {

            // int[][] a = {new int[]{13,15}, new int[]{1,13}};
            // Console.WriteLine(N253.MinMeetingRooms(a));
            
            // N545.TreeNode t=new N545.TreeNode(1,new N545.TreeNode(21,null,null),new N545.TreeNode(31,null,null));
            // N545 n545=new N545();
            // List<int> res= (List<int>)n545.BoundaryOfBinaryTree(t);
            // foreach (int i in res)
            // {
            //     Console.WriteLine(i);
            // }
            
            //
            //         5
            //     4       6
            // 1      2  7     8

            TreeNode n5=new TreeNode(7,null,null);
            TreeNode n6=new TreeNode(8,null,null);
            TreeNode n3=new TreeNode(1,null,null);
            TreeNode n4=new TreeNode(2,null,null);
            TreeNode n1=new TreeNode(4,n3,n4);
            TreeNode n2=new TreeNode(6,null,null);
            TreeNode n0=new TreeNode(5,n1,n2);
            
            Console.WriteLine("原 层序遍历 LevelOrder");
            N102 n102 = new N102();
            IList<IList<int>> res = n102.LevelOrder(n0);
            foreach (List<int> i in res)
            {
                Console.WriteLine("------");
                for (int j = 0; j < i.Count; j++)
                {
                    Console.Write(i[j]+" ");
                }
                Console.WriteLine("------");
            }
            
            //144
            // N144TreeNode n144TreeNode= new N144TreeNode();
            // List<int> res= (List<int>)n144TreeNode.PreorderTraversal(n0);
            
            // N107 n107=new N107();
            // List<IList<int>> res = (List<IList<int>>) n107.LevelOrderBottom(n0);
            
            // foreach (List<int> i in res)
            // {
            //     Console.WriteLine(i);
            // }
            // string _str = "aab";
            // int _startindex = 0;
            // N131 n131=new N131();
            // n131.Partition(_str);
            
            // int[] a={3,3,3,2,5};
            // N376 n376=new N376();
            // int res= n376.WiggleMaxLength(a);
            // Console.WriteLine("res:"+res);
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
