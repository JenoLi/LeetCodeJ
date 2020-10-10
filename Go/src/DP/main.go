package main

import (
	"DP/N70"
	"fmt"
)

func main() {
	n:=6
	sum:=N70.ClimbStairs(n)
	fmt.Printf("stairs:%d ways:%d",n,sum)
}
