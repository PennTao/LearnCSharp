using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNextNodeInTree
{
    class TreeNode
    {
        public TreeNode left;
        public TreeNode right;
        public TreeNode parent;
        public int val { get; set; }
        public TreeNode(int a)
        {
            val = a;
        }
        

    }
}
