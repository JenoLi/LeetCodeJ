using System.Collections.Generic;

namespace First
{
    public class N145
    {
        //后序，左右中
        public IList<int> PostorderTraversal(TreeNode root) {
            List<int> result=new List<int>();
            Stack<TreeNode> st=new Stack<TreeNode>();
            if(root!=null) st.Push(root);

            while (st.Count>0)
            {
                TreeNode node = st.Peek();
                if (node!= null)
                {
                    st.Pop();
                    st.Push(node);
                    st.Push(null);
                    
                    if(node.right!=null) st.Push(node.right);
                    if(node.left!=null) st.Push(node.left);
                }
                else
                {
                    st.Pop();
                    node = st.Pop();
                    result.Add(node.val);
                }
            }
            return result;
        }
    }
}