using System;
using System.Collections.Generic;

namespace First
{
    public class N253
    {
        public static int MinMeetingRooms(int[][] intervals)
        {
            //上下车法，计算同时在车上的最大数
            int maxRoom = 0;
            int curRoom = 0;
            int[] meetX=new int[intervals.Length];
            int[] meetY=new int[intervals.Length];
            for (int i = 0; i < intervals.Length; i++)
            {
                meetX[i] = intervals[i][0]*10+2;
                meetY[i] = intervals[i][1]*10+1;
            }
            int[] meet=new int[intervals.Length*2];
            meetX.CopyTo(meet,0);
            meetY.CopyTo(meet,intervals.Length);
            Array.Sort(meet);
            foreach (int time in meet)
            {
                Console.WriteLine("meet:"+time);
                if (time % 10 == 1)
                {
                    curRoom --;
                }
                else
                {
                    curRoom ++;
                }
                maxRoom = Math.Max(maxRoom, curRoom);
            }

            return maxRoom;
            // int[] startTimes = new int[intervals.Length];
            // int[] endTimes = new int[intervals.Length];
            // for (int i = 0; i < intervals.Length; i++)
            // {
            //     startTimes[i] = intervals[i][0];
            //     endTimes[i] = intervals[i][1];
            // }
            //
            // Array.Sort(startTimes);
            // Array.Sort(endTimes);
            //
            // int minRooms = 0;
            // int start_index = 0, end_index = 0;
            //
            // while (start_index < startTimes.Length)
            // {
            //     if (startTimes[start_index] < endTimes[end_index])
            //     {
            //         start_index++;
            //         minRooms++;
            //     }
            //     else
            //     {
            //         start_index++;
            //         end_index++;
            //     }
            // }
            //
            // return minRooms;
        }
    }
}