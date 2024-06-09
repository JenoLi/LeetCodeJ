using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;

namespace No2024.StackQueue
{
    public class N225
    {
        
    }
    
    //用队列模拟栈 （栈后进先出 队列先进先出）
    //用两个队列
    //队列1 的最后一个数，是pop需要取的数
    //队列2 用来缓存除最后一个的其他数
    public class MyStack
    {
        private Queue<int> q1 = new Queue<int>();
        private Queue<int> q2 = new Queue<int>();
        public MyStack() {

        }
    
        public void Push(int x) {
            q1.Enqueue(x);
        }
    
        public int Pop()
        {
            int size = q1.Count;
            if (size == 0)
                return -1;
            size--;//预留最后一个元素
            while (size>0)
            {
                size--;
                q2.Enqueue(q1.Dequeue());
            }

            int res = q1.Dequeue();
            foreach (int i in q2)
            {
                q1.Enqueue(i);
            }
            q2.Clear();
            return res;
        }
    
        public int Top()
        {
            int temp = this.Pop();
            this.Push(temp);
            return temp;
        }
    
        public bool Empty()
        {
            return q1.Count < 1;
        }
    }
}