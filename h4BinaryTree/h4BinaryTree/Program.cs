using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h4BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *       20
             *      /  \
             *     15  41
             *     ağacını oluşturan kodu yazalım
             */
            TreeNode kok = new TreeNode(20);
            kok.left = new TreeNode(15);
            kok.right = new TreeNode(41);
        }
    }
}
