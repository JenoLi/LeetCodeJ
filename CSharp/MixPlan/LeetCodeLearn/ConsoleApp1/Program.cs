using System;

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
            
            TreeNode n3=new TreeNode(1,null,null);
            TreeNode n4=new TreeNode(2,null,null);
            TreeNode n1=new TreeNode(4,n3,n4);
            TreeNode n2=new TreeNode(6,null,null);
            TreeNode n0=new TreeNode(5,n1,n2);

            //144
            // N144TreeNode n144TreeNode= new N144TreeNode();
            // List<int> res= (List<int>)n144TreeNode.PreorderTraversal(n0);
            
            // N107 n107=new N107();
            // List<IList<int>> res = (List<IList<int>>) n107.LevelOrderBottom(n0);
            
            // foreach (List<int> i in res)
            // {
            //     Console.WriteLine(i);
            // }
            string _str = "aab";
            int _startindex = 0;
            for (int i = _startindex; i < _str.Length; i++)
            {
                // Console.WriteLine("1:");
                bool ispalindrome = isPalindrome(_str, _startindex, i);
                // Console.WriteLine("2:");
                // if (true)
                // {
                //     Console.WriteLine("3:");
                //     string sub = _str.Substring(i, i-_startindex + 1);
                //     Console.WriteLine("4:"+i+" "+sub);
                // }
                // else
                // {
                //     continue;
                // }
            }
        }
        static bool isPalindrome(string s, int start, int end) {
            for (int i = start, j = end; i < j; i++, j--) {
                Console.WriteLine("0:回文判断："+s[i]+" "+s[j]);
                if (s[i] != s[j]) {
                    Console.WriteLine("false:");
                    return false;
                }
            }
            Console.WriteLine("true:");
            return true;
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
