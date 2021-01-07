package main

import (
	"sort"
)

func init() {
	
}

func minMeetingRooms(intervals [][]int) int {

	temp:=MyIntSlice(intervals)
	sort.Sort(temp)
	//for _,v:=range temp{
	//	fmt.Printf("%v\n",v)
	//}
	return 0
}

type MyIntSlice [][]int

func (m MyIntSlice) Len() int{
	return len(m)
}

func (m MyIntSlice) Less(i, j int) bool {
	return m[i][0]<m[j][0]
}
func (m MyIntSlice) Swap(i, j int) {
	m[i], m[j] = m[j], m[i]
}