using System;
using System.Collections;
using System.Collections.Generic;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            // string a = "0123";
            // int b = a[2]-'0';//自动转换成十进制int类型，不 -‘0’ 会输出ascii码
            // Console.WriteLine(b);
            // Console.ReadKey();
            // int[][] a = new int[2][2] {{2, 9}, {1, 10}};
            int[][] a = {new int[]{2,9}, new int[]{1, 10}};
            MinMeetingRooms(a);
        }

        public static int MinMeetingRooms(int[][] intervals)
        {
            Array.Sort(intervals,new MyComparable());
            foreach (int[] i in intervals)
            {
                Console.WriteLine(i[0]+","+i[1]);
                // foreach (int i1 in i)
                // {
                //     Console.WriteLine(i1);
                // }
            }
            Console.ReadKey();
            return 1;
        }
        public class MyComparable:IComparer<int[]>
        {
            public  int Compare(int[] x, int[] y)
            {
                return x[0] - y[0];//返回值大于0表示x>y,等于0表示x=y,小于0表示x<y。Array.Sort内部会根据这个返回值来判断x和y的大小关系，并把小的元素放在前面
                //如果想降序怎么办，返回y[0]-x[0]即可
            }

        }
    }

}
