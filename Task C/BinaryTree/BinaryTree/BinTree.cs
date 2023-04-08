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
        public void InsertItem(string value)
        {
            Node newNode = new Node(value);

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

                    if (string.Compare(value, current.Value) < 0)
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
        public bool Contains(string item)
        {
            return Contains(Root, item);
        }

        /// <summary>
        /// Determines whether the specified subtree contains a specific item.
        /// </summary>
        /// <param name="node">The root node of the subtree to search.</param>
        /// <param name="item">The item to locate in the subtree.</param>
        /// <returns>true if the item is found in the subtree; otherwise, false.</returns>
        private bool Contains(Node node, string item)
        {
            if (node == null)
            {
                return false;
            }
            else if (node.Value == item)
            {
                return true;
            }
            else if (string.Compare(item, node.Value) < 0)
            {
                return Contains(node.Left, item);
            }
            else
            {
                return Contains(node.Right, item);
            }
        }

        /// <summary>
        /// Returns the longest string present in the tree.
        /// </summary>
        /// <returns>The longest string present in the tree.</returns>
        public string Longest()
        {
            return Longest(Root);
        }

        // <summary>
        /// Recursively searches the tree for the longest string.
        /// </summary>
        /// <param name="node">The current node being searched.</param>
        /// <returns>The longest string in the subtree.</returns>
        private string Longest(Node node)
        {
            if (node == null)
            {
                return "";
            }
            else
            {
                string left = Longest(node.Left);
                string right = Longest(node.Right);

                if (left.Length > right.Length)
                {
                    return left.Length > node.Value.Length ? left : node.Value;
                }
                else
                {
                    return right.Length > node.Value.Length ? right : node.Value;
                }
            }
        }

        /// <summary>
        /// Finds the string associated with the first common ancestor of two given strings in the tree.
        /// </summary>
        /// <param name="str1">The first string to search for.</param>
        /// <param name="str2">The second string to search for.</param>
        /// <returns>The string associated with the first common ancestor of the two given strings, or an empty string if one or both strings are not present in the tree.</returns>

        public string Ancestor(string str1, string str2)
        {
            Node ancestor = Ancestor(Root, str1, str2);

            if (ancestor == null)
            {
                return "";
            }
            else
            {
                return ancestor.Value;
            }
        }

        /// <summary>
        /// Recursively searches the tree for the first common ancestor of two given strings.
        /// </summary>
        /// <param name="node">The current node being searched.</param>
        /// <param name="str1">The first string to search for.</param>
        /// <param name="str2">The second string to search for.</param>
        /// <returns>The node associated with the first common ancestor of the two given strings, or null if one or both strings are not present in the tree.</returns>
        private Node Ancestor(Node node, string str1, string str2)
        {
            if (node == null)
            {
                return null;
            }

            if (node.Value == str1 || node.Value == str2)
            {
                return node;
            }

            Node left = Ancestor(node.Left, str1, str2);
            Node right = Ancestor(node.Right, str1, str2);

            if (left != null && right != null)
            {
                return node;
            }
            else
            {
                return left ?? right;
            }
        }
    }
}
