package main

import (
	//"Array/350"
	"Array/27"
	"fmt"
)

func main() {

	//350 ---------------
	//	n1:= []int{1,2,3,1,5}
	//	n2:= []int{1,5,1}
	//	res:=350.Intersect(n1,n2)
	//for _,v:=range res{
	//	println(v)

	//27 ---------------
	n1 := []int{0,1,2,2,3,0,4,2}
	res := _7.RemoveElement(n1, 2)
	printSlice(res)
}

func printSlice(x []int){
	fmt.Printf("len=%d cap=%d slice=%v\n",len(x),cap(x),x)
}
