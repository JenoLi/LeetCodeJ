using System.Collections.Generic;

namespace No2024.TreeNo2
{
    public class N144
    {
        
        //前序遍历 递归
        // public IList<int> PreorderTraversal(TreeNode root)
        // {
        //     List<int> res = new List<int>();
        //     Traversal(root,res);
        //     return res;
        // }
        //
        // private void Traversal(TreeNode node,List<int> list)
        // {
        //     if(node==null)
        //         return;
        //     list.Add(node.val);//中
        //     Traversal(node.left,list);//左
        //     Traversal(node.right,list);//右
        // }
        
        //前序遍历 迭代  中左右
        public IList<int> PreorderTraversal(TreeNode root)
        {
            List<int> res = new List<int>();
            Stack<TreeNode> st = new Stack<TreeNode>();
            if(root!=null) st.Push(root);
            while (st.Count>0)
            {
                TreeNode cur = st.Peek();
                if (cur != null)
                {
                    st.Pop();//弹出 防止重复操作
                    if(cur.right!=null) st.Push(cur.right);
                    if(cur.left!=null) st.Push(cur.left);
                    
                    st.Push(cur);
                    st.Push(null);
                }
                else
                {
                    st.Pop();//弹出NULL
                    res.Add(st.Pop().val);
                }
            }

            return res;
        }

    }
}