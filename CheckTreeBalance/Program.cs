using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTreeBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(4);
            Console.WriteLine("add root");
            root.left = new TreeNode(5);
            Console.WriteLine("add root left");
          

            if (isBalance(root) == true)
            {
                Console.WriteLine("balance!");
            }
            else
            {
                Console.WriteLine("not balance!");
            }
            root.right = new TreeNode(6);
            Console.WriteLine("add root right");
            root.right.right = new TreeNode(7);
            Console.WriteLine("add root right right");
            root.right.right.right = new TreeNode(8);
            Console.WriteLine("add root right right right");
            if (isBalance(root) == true)
            {
                Console.WriteLine("balance!");
            }
            else
            {
                Console.WriteLine("not balance!");
            }
        }
        static bool isBalance(TreeNode root)
        {
            if (root == null)
                return true;
            else
                return Math.Abs(depth(root.left) - depth(root.right)) < 2;
        }
        static int depth(TreeNode root)
        {
            
            if (root == null)
                return 0;
            
            int ldepth = depth(root.left);
            int rdepth = depth(root.right);
            
            return Math.Max(ldepth, rdepth) + 1;
        }
    }
}
