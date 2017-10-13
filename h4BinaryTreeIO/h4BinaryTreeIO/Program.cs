using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h4BinaryTreeIO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *      41
             *     /  \
             *    18  64
             *    ağacını oluşturalım.
             */
            TreeNode kok = new TreeNode(41);//Kök düğümünü oluştur
            TreeNode sol=new TreeNode(18);//Sol çocuğu oluştur ve bağla
            kok.left=sol;
            kok.right = new TreeNode(64);//Sağ çocuğu oluştur ve bağla
            //kok.right.right.left.right.left
        }
    }
}
