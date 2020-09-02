using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        public Node root;

        public void Add(int currentNodeValue)
        {

            int currentNode; 

            if (root == null)
            {
                root = new Node(currentNodeValue);
            }

            else
            {
                currentNode = currentNodeValue;
            }
            
            if (root.Data > currentNodeValue)
            {
                root.leftNode.Data = currentNodeValue;
            }

            if (root.Data < currentNodeValue)
            {
                root.rightNode.data = currentNodeValue;
            }

        }


        public void Search()
        {

        }
    }
}
