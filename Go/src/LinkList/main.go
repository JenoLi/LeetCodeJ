package main

import (

	"LinkList/A1"

	)


func main() {
	type ListNode=A1.ListNode

	N1:=new(ListNode)
	N1.Val=1
	N2:=new(ListNode)
	N2.Val=2
	N3:=new(ListNode)
	N3.Val=3
	N4:=new(ListNode)
	N4.Val=4
	N1.Next=N2
	N2.Next=N3
	N3.Next=N4

	A1.RemoveNthFromEnd(N1,2)

	temp:=N1
	for temp!=nil{
		println(temp.Val)
		temp=temp.Next
	}
}
