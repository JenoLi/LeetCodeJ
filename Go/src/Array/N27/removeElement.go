package N27
//原地删除(27)

import "fmt"

func RemoveElement(nums []int, val int) []int {
	for i := 0; i < len(nums); {
		fmt.Printf("nums[%d]=%d \n",i,nums[i])
		if nums[i] == val {
			nums=append(nums[0:i],nums[i+1:]...)
			fmt.Printf("%v\n",nums)
		}else{
			i++
		}
	}
	return nums
}
