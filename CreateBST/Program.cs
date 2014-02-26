using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Given a sorted array, create a BST with minimun height*/
namespace CreateBST
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            for (int i = 0; i < 5; i++)
            {
                a[i] = i;
            }
            TreeNode root;
            root = CreateBinarySearchTree(a, 0, 4);
            InOrderTrav(root);
        }
       
        static TreeNode CreateBinarySearchTree(int[] a, int left, int right)
        {

            if (left > right)
            {
                return null;

            }
            else
            {
                int mid = (left + right) / 2;
                TreeNode root = new TreeNode(a[mid]);
                root.left = CreateBinarySearchTree(a, left, mid - 1);
                root.right = CreateBinarySearchTree(a, mid + 1, right);
                return root;
            }
        }
        static void InOrderTrav(TreeNode root)
        {
            if (root == null)
                return;
            
            InOrderTrav(root.left);
            Console.WriteLine(root.val);
            InOrderTrav(root.right);
        }
    }
}
