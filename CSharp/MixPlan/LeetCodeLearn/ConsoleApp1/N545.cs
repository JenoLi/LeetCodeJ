using System;
using System.Collections;
using System.Collections.Generic;

namespace First
{
    public class N545
    {
        public IList<int> BoundaryOfBinaryTree(TreeNode root)
        {
            List<int> res = new List<int>();
            dfs(root, true, true, res);
            return res;
        }

// # dfs标记左右边界即可。题目中说逆时针，实际上很像先序遍历的变种.
        private void dfs(TreeNode node, bool leftBound, bool rightBound, List<int> res) {
            if (node == null) {
                return;
            } 
// 初始化dfs的时候leftBound是true，所以root一定是res中第一个元素。
            if (leftBound) {
                res.Add(node.val);
            }
// # 当前node是叶子节点，加入res
            else if (node.left == null && node.right == null) {
                res.Add(node.val);
                return;
            }
// # 当前node不是叶子节点。按照题目给的顺序，先处理左子树再处理右子树。在处理左子树时，右子树的判断条件变多了，起到剪枝的作用。处理右子树时反过来，原理和目的一致。
            dfs(node.left, leftBound, !leftBound && rightBound && node.right == null, res);
            dfs(node.right, !rightBound && leftBound && node.left == null, rightBound, res);
// # 在这里，左边界、叶子结点需要加入res的都处理完了，做右边界的判断。
            if (!leftBound && rightBound) {
                res.Add(node.val);
            }
        }
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}