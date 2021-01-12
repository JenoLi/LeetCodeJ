using System;
using System.Collections;
using System.Collections.Generic;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {

            // int[][] a = {new int[]{13,15}, new int[]{1,13}};
            // Console.WriteLine(N253.MinMeetingRooms(a));
            
            N545.TreeNode t=new N545.TreeNode(1,new N545.TreeNode(21,null,null),new N545.TreeNode(31,null,null));
            N545 n545=new N545();
            List<int> res= (List<int>)n545.BoundaryOfBinaryTree(t);
            foreach (int i in res)
            {
                Console.WriteLine(i);
            }
            // N545.BoundaryOfBinaryTree(t);
        }
    }

}
