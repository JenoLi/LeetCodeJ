using System.Collections;
using System.Collections.Generic;

namespace No2024.StackQueue
{
    public class N232
    {
    }
    //栈先进后出 队列先进先出
    //用两个栈模拟队列 out栈 是从in栈的数据pop出来的，所以out栈的顺序是in的倒序，out的顺序就是目标的队列pop顺序
    public class MyQueue
    {
        private Stack<int> stIn=new Stack<int>();
        private Stack<int> stOut=new Stack<int>();
        public MyQueue()
        {
            
        }
    
        public void Push(int x) {
            stIn.Push(x);
        }
    
        public int Pop()
        {
            if (stOut.Count < 1)
            {
                while (stIn.Count>0)
                {
                    int temp = stIn.Pop();
                    stOut.Push(temp);
                }
            }
            return stOut.Pop();
        }
    
        public int Peek()
        {
            int temp = this.Pop();
            stOut.Push(temp);
            return temp;
        }
    
        public bool Empty()
        {
            return stIn.Count < 1 && stOut.Count < 1;
        }
    }
    
}