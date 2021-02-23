using System;
using System.Collections.Generic;

namespace First
{
    public class N253
    {
        public int MinMeetingRooms(int[][] intervals)
        {
            //上下车法，计算同时在车上的最大数
            int maxMeeting=0;
            int curMeeting = 0;
            int[] startInt=new int[intervals.Length];
            int[] endInt=new int[intervals.Length];
            int[] allInt=new int[intervals.Length*2];
            for (int i = 0; i < intervals.Length; i++)
            {
                startInt[i] = intervals[i][0] * 10 + 2;
                endInt[i] = intervals[i][1] * 10 + 1;//把出排在前面，防止同数时先加后减
            }
            startInt.CopyTo(allInt,0);
            endInt.CopyTo(allInt,intervals.Length);
            Array.Sort(allInt);
            foreach (int i in allInt)
            {
                if (i % 10 == 1)//先减后加，因为可以头尾相接
                {
                    curMeeting -= 1;
                }
                else
                {
                    curMeeting += 1;
                }

                maxMeeting = Math.Max(maxMeeting, curMeeting);
            }
            return maxMeeting;



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