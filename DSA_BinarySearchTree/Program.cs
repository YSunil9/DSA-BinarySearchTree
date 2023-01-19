namespace DSA_BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> function = new BinarySearchTree<int>(56);
            function.AddNode(30);
            function.AddNode(70);
            function.AddNode(3);
            function.AddNode(11);
            function.AddNode(16);
            function.AddNode(67);
            function.AddNode(63);
            function.AddNode(65);
            function.AddNode(60);
            function.AddNode(95);
            function.AddNode(40);
            function.AddNode(22);
            function.Display();
            function.GetSize();
        }
    }
}