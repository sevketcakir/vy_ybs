using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h4BinaryTreeIO
{
    class TreeNode
    {
        public int value;//Değer
        public TreeNode left;//Sol alt çocuk
        public TreeNode right;//Sağ alt çocuk
        public TreeNode() { }
        public TreeNode(int value)
        {
            this.value = value;
        }
        public TreeNode(int value, TreeNode left, TreeNode right)
        {
            this.value = value;
            this.left = left;
            this.right = right;
        }
    }
}
