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
            // int[][] a = {new int[]{0,30}, new int[]{5,10}, new int[]{15,20}};
            int[][] a = {new int[]{13,15}, new int[]{1,13}};
            Console.WriteLine(N253.MinMeetingRooms(a));
        }
    }

}
