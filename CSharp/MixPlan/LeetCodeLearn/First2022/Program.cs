using System;
using First2022.Array;

namespace First2022
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //N704
            N704 n704 = new N704();
            int[] nums = new[] {-1,0,3,5,9,12};
            Console.WriteLine(n704.Search(nums,2));
        }
    }
}