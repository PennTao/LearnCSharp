using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Find the next node(in order) of the given node in a binary tree*/
namespace FindNextNodeInTree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);           
            root.right = new TreeNode(3); 
            root.left.left = new TreeNode(4);            
            root.left.right = new TreeNode(5);           
            root.left.right.left = new TreeNode(6);
            root.right.right = new TreeNode(7);
            root.right.right.right = new TreeNode(8);
            root.left.parent = root;
            root.right.parent = root;
            root.left.left.parent = root.left;
            root.left.right.parent = root.left;
            root.left.right.left.parent = root.left.right;
            root.right.right.parent = root.right;
            root.right.right.right.parent = root.right.right;
            Console.WriteLine("Inorder traversal: 4 2 6 5 1 3 7 8");
            TreeNode curNode;
            curNode = FindNextNodeInTree(root.left.right.left);
            Console.WriteLine("The next of {0} is {1}",root.left.right.left.val,curNode.val);
            curNode = FindNextNodeInTree(root.left.right);
            Console.WriteLine("The next of {0} is {1}", root.left.right.val, curNode.val);

        }
        static TreeNode FindNextNodeInTree(TreeNode node)
        {
            if (node == null)
                return null;

            if (node.right != null)
            {
                return LeftMostChilde(node.right);

            }
            else
            {
                TreeNode curNode = node;
                TreeNode curParent = node.parent;
                while (curParent != null && curParent.left != curNode)
                {
                    curNode = curParent;
                    curParent = curParent.parent;
                }
                return curParent;
            }




        }

        static TreeNode LeftMostChilde(TreeNode node)
        {
            TreeNode res = node;
            if (node == null)
                return null;
            while (res.left != null)
                res = res.left;
            return res;
        }
    }
}
