namespace BinaryTree
{
    /// <summary>
    /// Represents the entry point of the application.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            BinTree tree = new BinTree();
            tree.InsertItem(50);
            tree.InsertItem(25);
            tree.InsertItem(75);
            tree.InsertItem(15);
            tree.InsertItem(35);
            tree.InsertItem(65);
            tree.InsertItem(85);

            Console.Write("InOrder Traversal: ");
            tree.InOrder(tree.Root);
            Console.WriteLine();

            Console.Write("PostOrder Traversal: ");
            tree.PostOrder(tree.Root);
            Console.WriteLine();

            Console.Write("PreOrder Traversal: ");
            tree.PreOrder(tree.Root);
            Console.WriteLine();
        }
    }
}