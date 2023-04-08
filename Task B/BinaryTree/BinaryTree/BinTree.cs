using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    /// <summary>
    /// Represents a binary tree.
    /// </summary>
    internal class BinTree
    {
        /// <summary>
        /// The root node of the tree.
        /// </summary>
        public Node Root;

        /// <summary>
        /// Inserts an item into the tree.
        /// </summary>
        /// <param name="value">The value to insert.</param>
        public void InsertItem(int value)
        {
            Node newNode = new Node();
            newNode.Value = value;

            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                Node current = Root;
                Node parent;

                while (true)
                {
                    parent = current;

                    if (value < current.Value)
                    {
                        current = current.Left;

                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.Right;

                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Performs an in-order traversal of the tree.
        /// </summary>
        /// <param name="node">The root node of the subtree to traverse.</param>
        public void InOrder(Node node)
        {
            if (node != null)
            {
                InOrder(node.Left);
                Console.Write(node.Value + " ");
                InOrder(node.Right);
            }
        }

        /// <summary>
        /// Performs a post-order traversal of the tree.
        /// </summary>
        /// <param name="node">The root node of the subtree to traverse.</param>
        public void PostOrder(Node node)
        {
            if (node != null)
            {
                PostOrder(node.Left);
                PostOrder(node.Right);
                Console.Write(node.Value + " ");
            }
        }

        /// <summary>
        /// Performs a pre-order traversal of the tree.
        /// </summary>
        /// <param name="node">The root node of the subtree to traverse.</param>
        public void PreOrder(Node node)
        {
            if (node != null)
            {
                Console.Write(node.Value + " ");
                PreOrder(node.Left);
                PreOrder(node.Right);
            }
        }

        /// <summary>
        /// Determines whether the tree contains a specific item.
        /// </summary>
        /// <param name="item">The item to locate in the tree.</param>
        /// <returns>true if the item is found in the tree; otherwise, false.</returns>
        public bool Contains(int item)
        {
            return Contains(Root, item);
        }

        /// <summary>
        /// Determines whether the specified subtree contains a specific item.
        /// </summary>
        /// <param name="node">The root node of the subtree to search.</param>
        /// <param name="item">The item to locate in the subtree.</param>
        /// <returns>true if the item is found in the subtree; otherwise, false.</returns>
        private bool Contains(Node node, int item)
        {
            if (node == null)
            {
                return false;
            }
            else if (node.Value == item)
            {
                return true;
            }
            else if (item < node.Value)
            {
                return Contains(node.Left, item);
            }
            else
            {
                return Contains(node.Right, item);
            }
        }
    }
}
