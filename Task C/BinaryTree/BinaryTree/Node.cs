using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    /// <summary>
    /// Represents a node in a binary tree.
    /// </summary>
    internal class Node
    {
        /// <summary>
        /// The value stored in the node.
        /// </summary>
        public string Value;

        /// <summary>
        /// The left child of the node.
        /// </summary>
        public Node Left;

        /// <summary>
        /// The right child of the node.
        /// </summary>
        public Node Right;

        public Node(string value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
}
