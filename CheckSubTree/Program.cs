using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Given two binary trees A and B, check if B is A's subtree */
namespace CheckSubTree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root1 = new TreeNode(1);
            root1.left = new TreeNode(2);
            root1.right = new TreeNode(3);
            root1.left.left = new TreeNode(4);

            TreeNode root2 = new TreeNode(2);
            root2.left = new TreeNode(4);
            Console.WriteLine("Tree 1");
            Console.WriteLine("         1");
            Console.WriteLine("     2       3");
            Console.WriteLine("4");

            Console.WriteLine("Tree 2");
            Console.WriteLine("     2");
            Console.WriteLine("4");
            if (CheckSub(root1, root2))
            {
                Console.WriteLine("Tree 2 is a sub tree");
            }
            else
            {
                Console.WriteLine("Tree 2 is NOT a sub tree");
            }
            root2.right = new TreeNode(3);
            Console.WriteLine("Tree 3");
            Console.WriteLine("     2");
            Console.WriteLine("4            3");
            if (CheckSub(root1, root2))
            {
                Console.WriteLine("Tree 2 is a sub tree");
            }
            else
            {
                Console.WriteLine("Tree 3 is NOT a sub tree");
            }
        }

        static bool CheckSameTree(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null)
            {
                return true;
            }
            else if (root1 == null || root2 == null)
            {
                return false;
            }
            if (root1.val == root2.val)
            {
                return CheckSameTree(root1.left, root2.left) && CheckSameTree(root1.right, root2.right);
            }
            else
            {
                return false;
            }
        }
        static bool CheckSub(TreeNode root1, TreeNode root2)
        {
            if (root2 == null)
                return true;
            if (root1 == null)
            {
                return false;
            }
            if (root1.val == root2.val)
            {
                return CheckSameTree(root1, root2);
            }
            return CheckSub(root1.left, root2) || CheckSub(root1.right, root2);

        }
    }
}
