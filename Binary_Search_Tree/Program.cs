namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a option.\n1.Create a Binary Tree\n2.Create BST shown in fig.\n3.Find 63 in tree");
            Console.WriteLine();
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (option)
            {
                case 1:
                    BST1<int> bst1 = new BST1<int>(56);
                    bst1.Insert(30);
                    bst1.Insert(70);
                    bst1.Display();
                    break;
                case 2:
                    BST2<int> bst2 = new BST2<int>(56);
                    bst2.Insert(30);
                    bst2.Insert(70);
                    bst2.Insert(22);
                    bst2.Insert(40);
                    bst2.Insert(60);
                    bst2.Insert(95);
                    bst2.Insert(11);
                    bst2.Insert(65);
                    bst2.Insert(3);
                    bst2.Insert(16);
                    bst2.Insert(63);
                    bst2.Insert(67);
                    bst2.Display();
                    bst2.GetSize();
                    break;
                case 3:
                    BST3<int> bst3 = new BST3<int>(56);
                    bst3.Insert(30);
                    bst3.Insert(70);
                    bst3.Insert(22);
                    bst3.Insert(40);
                    bst3.Insert(60);
                    bst3.Insert(95);
                    bst3.Insert(11);
                    bst3.Insert(65);
                    bst3.Insert(3);
                    bst3.Insert(16);
                    bst3.Insert(63);
                    bst3.Insert(67);
                    bst3.Display();
                    //bst3.GetSize();
                    bool result = bst3.IfExists(63, bst3);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}