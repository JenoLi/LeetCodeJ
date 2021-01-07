package main

import "math"

func init() {
	
}

func canAttendMeetings(intervals [][]int)  bool{
	for i:=0;i< len(intervals);i++{
		for j:=i+1;j<len(intervals);j++{
			if Overlap(intervals[i],intervals[j]){
				return false
			}
		}
	}
	return true
}

func Overlap(a1 []int,a2 []int ) bool {
	return (math.Min(float64(a1[1]), float64(a2[1]))>math.Max(float64(a1[0]), float64(a2[0])))
}
