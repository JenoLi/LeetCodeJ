using System;
using System.Collections.Generic;

namespace First
{
    public class N253
    {
        public static int MinMeetingRooms(int[][] intervals)
        {
            int[] startTimes = new int[intervals.Length];
            int[] endTimes = new int[intervals.Length];
            for (int i = 0; i < intervals.Length; i++)
            {
                startTimes[i] = intervals[i][0];
                endTimes[i] = intervals[i][1];
            }
        
            Array.Sort(startTimes);
            Array.Sort(endTimes);
        
            int minRooms = 0;
            int start_index = 0, end_index = 0;
        
            while (start_index < startTimes.Length)
            {
                if (startTimes[start_index] < endTimes[end_index])
                {
                    start_index++;
                    minRooms++;
                }
                else
                {
                    start_index++;
                    end_index++;
                }
            }
        
            return minRooms;
        }
    }
}