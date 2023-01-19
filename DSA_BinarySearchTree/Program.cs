namespace DSA_BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>(56);
            binarySearchTree.AddNode(30);
            binarySearchTree.AddNode(70);
            binarySearchTree.Display();
        }
    }
}