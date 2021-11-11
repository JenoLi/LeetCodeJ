using System;
using System.Collections.Generic;

namespace Second2021.Tree
{
    public class N257
    {
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            List<string> res = new List<string>();
            List<int> path = new List<int>();
            Travesal(res,root,path);
            return res;
        }

        public void Travesal(List<string> _res,TreeNode _curnode, List<int> _path)
        {
            //单层逻辑
            _path.Add(_curnode.val);
            
            //终止条件 叶子
            if (_curnode.left == null && _curnode.right == null)
            {
                string sPath = "";
                for (int i = 0; i < _path.Count-1; i++)
                {
                    sPath += _path[i] + "->";
                }
                sPath += _path[_path.Count - 1].ToString();
                _res.Add(sPath);
            }
            
            //单层逻辑 继续遍历子节点
            if (_curnode.left != null)
            {
                Travesal(_res,_curnode.left, _path);
                _path.RemoveAt(_path.Count-1);
            }
            if (_curnode.right != null)
            {
                Travesal(_res,_curnode.right,_path);
                _path.RemoveAt(_path.Count-1);
            }
        }
        
    }
}