namespace BinaryTree
{
    /// <summary>
    /// Represents the entry point of the application.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new binary tree
            BinTree tree = new BinTree();

            // Insert some strings into the tree
            tree.InsertItem("helle");
            tree.InsertItem("world");
            tree.InsertItem("this");
            tree.InsertItem("is");
            tree.InsertItem("a");
            tree.InsertItem("test");
            tree.InsertItem("of");
            tree.InsertItem("the");
            tree.InsertItem("binary");
            tree.InsertItem("tree");

            // Test the Longest method
            string longest = tree.Longest();
            Console.WriteLine("The longest string in the tree is: " + longest);

            // Test the Ancestor method with two strings that are present in the tree
            string str1 = "idea";
            string str2 = "waif";
            string ancestor = tree.Ancestor(str1, str2);
            if (ancestor != "")
            {
                Console.WriteLine("The first common ancestor of " + str1 + " and " + str2 + " is: " + ancestor);
            }
            else
            {
                Console.WriteLine("One or both of the strings " + str1 + " and " + str2 + " are not present in the tree.");
            }

            // Test the Ancestor method with two strings where one or both are not present in the tree
            str1 = "test";
            str2 = "missing";
            ancestor = tree.Ancestor(str1, str2);
            if (ancestor != "")
            {
                Console.WriteLine("The first common ancestor of " + str1 + " and " + str2 + " is: " + ancestor);
            }
            else
            {
                Console.WriteLine("One or both of the strings " + str1 + " and " + str2 + " are not present in the tree.");
            }

            // Wait for user input before closing console window
            Console.ReadLine();
        
        }
    }
}