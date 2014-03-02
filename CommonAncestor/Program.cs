using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Find the common ancestors of two nodes in a binary tree*/
namespace CommonAncestor
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(2);
            root.left = new TreeNode(1);
            root.right = new TreeNode(3);
            root.right.left = new TreeNode(4);
            root.right.right = new TreeNode(9);
            root.right.right.left = new TreeNode(8);
            root.right.right.right = new TreeNode(10);
            TreeNode node1 = new TreeNode(1);
            TreeNode node2 = new TreeNode(8);
            TreeNode res = FindCommonAncestor(root, node1, node2);
            Console.WriteLine("     2");
            Console.WriteLine("1            3");
            Console.WriteLine("         4       9");
            Console.WriteLine("             8       10");
            Console.WriteLine("common ancestor of 1, 8 is {0}",res.val);
            node1 = new TreeNode(4);
            node2 = new TreeNode(10);
            res = FindCommonAncestor(root, node1, node2);
            Console.WriteLine("common ancestor of 4, 10 is {0}", res.val);
            Console.ReadLine();
        }
        static bool FindNode(TreeNode root, TreeNode target)
        {
            if (root == null)
                return false;
            if (root.val == target.val)
                return true;
            else
            {
                return FindNode(root.left, target) || FindNode(root.right, target);
            }

        }
        static TreeNode FindCommonAncestor(TreeNode root, TreeNode node1, TreeNode node2)
        {
            if (root.val == node1.val || root.val == node2.val)
                return root;
            if ((FindNode(root.left, node1) && FindNode(root.right, node2)) || (FindNode(root.left, node2) && FindNode(root.right, node1)))
                return root;
            if (FindNode(root.left, node1) && FindNode(root.left, node2))
                return FindCommonAncestor(root.left, node1, node2);
            else if(FindNode(root.right, node1) && FindNode(root.right, node2))
                return FindCommonAncestor(root.right, node1, node2);
            return null;
        }
    }
}
