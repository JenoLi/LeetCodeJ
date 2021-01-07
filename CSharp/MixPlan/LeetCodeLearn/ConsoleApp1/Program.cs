using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "0123";
            int b = a[2]-'0';
            Console.Write(b);
            Console.ReadKey();
            // MinMeetingRooms(new int[][] { [2, 9],[1, 10] });

        }

        public int MinMeetingRooms(int[][] intervals)
        {
            Array.Sort(intervals);
            foreach (int[] i in intervals)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            return 1;
        }
    }
}
