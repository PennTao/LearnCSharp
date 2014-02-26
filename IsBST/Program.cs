using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBST
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(2);
            root.left = new TreeNode(1);
            root.right = new TreeNode(3);
            root.right.right = new TreeNode(9);
            root.right.right.left = new TreeNode(8);
            root.right.right.right = new TreeNode(10);
            if (IsBinarySearchTree(root))
            {
                Console.WriteLine("This tree is BST");
            }
            else
            {
                Console.WriteLine("This tree is NOT BST");
            }

        }
        static void InOrderTraversal(TreeNode root, ref LinkedList<TreeNode> res)
        {
            if (root == null)
                return;
            
            InOrderTraversal(root.left, ref res);
            res.AddLast(root);
            InOrderTraversal(root.right, ref res);
 
        }
        static bool IsBinarySearchTree(TreeNode root)
        {
            bool result = true;
            LinkedList<TreeNode> res = new LinkedList<TreeNode>();

            InOrderTraversal(root, ref res);
#if DEBUG
            Console.WriteLine("in order traversal of the tree:");
            foreach (TreeNode i in res)
            {
                Console.WriteLine(i.val);
            }
            Console.WriteLine();
#endif
            int prev = int.MinValue;
            LinkedListNode<TreeNode> runner = res.First;
            while (runner.Next != null)
            {
                if (runner.Value.val < prev)
                {
                    result = false;
                    break;
                }
                prev = runner.Value.val;
                runner = runner.Next;
            }
            return result;
        }

    }
    
}
