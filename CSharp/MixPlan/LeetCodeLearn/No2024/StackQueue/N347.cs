using System.Collections.Generic;

namespace No2024.StackQueue
{
    public class N347
    {
        public int[] TopKFrequent(int[] nums, int k) {
            // //哈希表-标权重
            // Dictionary<int,int> dic = new();
            // for(int i = 0; i < nums.Length; i++){
            //     if(dic.ContainsKey(nums[i])){
            //         dic[nums[i]]++;
            //     }else{
            //         dic.Add(nums[i], 1);
            //     }
            // }
            // //优先队列-从小到大排列
            // PriorityQueue<int,int> pq = new();//C#10?
            // foreach(var num in dic){
            //     pq.Enqueue(num.Key, num.Value);
            //     if(pq.Count > k){
            //         pq.Dequeue();
            //     }
            // }
            //
            // // //Stack-倒置
            // // Stack<int> res = new();
            // // while(pq.Count > 0){
            // //     res.Push(pq.Dequeue());
            // // }
            // // return res.ToArray();
            //
            // //数组倒装
            // int[] res = new int[k];
            // for(int i = k - 1; i >= 0; i--){
            //     res[i] = pq.Dequeue();
            // }
            // return res;

            return new []{1};
        }
    }
}