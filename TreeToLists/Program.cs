using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Given a binary tree, create a linked list of all the nodes at each depth, 
 e.g. if you have a tree with depth D, you'll have D linked lists*/
namespace TreeToLists
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.right.left = new TreeNode(5);
            root.left.left.left = new TreeNode(6);
            Dictionary<int, LinkedList<TreeNode>> res = NDepthToNLists(root);
            for (int i = 0; i < res.Count; i++)
            {
                Console.WriteLine("Layer {0}", i);
                foreach (TreeNode j in res[i])
                {
                    Console.WriteLine(j.val);
                }

            }
        }

        static Dictionary<int, LinkedList<TreeNode>> NDepthToNLists(TreeNode root)
        {
            if (root == null)
                return null;
            Queue<TreeNode> buf = new Queue<TreeNode>();
            Queue<int> layer = new Queue<int>();
            TreeNode curNode;
            int curLayer;
            Dictionary<int, LinkedList<TreeNode>> res = new Dictionary<int,LinkedList<TreeNode>>();
            buf.Enqueue(root);
            layer.Enqueue(0);
            while (buf.Count > 0)
            {
                curNode = buf.Dequeue();
                curLayer = layer.Dequeue();
                if (!res.ContainsKey(curLayer))
                {
                    res.Add(curLayer, new LinkedList<TreeNode>());
                }
                res[curLayer].AddLast(curNode);


                if (curNode.left != null)
                {
                    buf.Enqueue(curNode.left);
                    layer.Enqueue(curLayer + 1);
                }
                if (curNode.right != null)
                {
                    buf.Enqueue(curNode.right);
                    layer.Enqueue(curLayer + 1);
                }
            }
            return res;
        }
    }
}
