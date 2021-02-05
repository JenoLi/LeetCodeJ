using System.Collections.Generic;

namespace First
{
    public class N145
    {
        //二叉树深度遍历，后序，左右中
        public IList<int> PostorderTraversal(TreeNode root) {
            List<int> result=new List<int>();
            Stack<TreeNode> st=new Stack<TreeNode>();
            if(root!=null) st.Push(root);
            while (st.Count>0)
            {
                TreeNode node = st.Peek();
                if (node != null)
                {
                    st.Pop();
                    st.Push(node);
                    st.Push(null);//插入标志位
                    
                    if(node.right!=null) st.Push(node.right);
                    if(node.left!=null) st.Push(node.left);
                }
                else
                {
                    st.Pop();//弹出null
                    result.Add(st.Pop().val);
                }
            }

            return result;

        }
    }
}