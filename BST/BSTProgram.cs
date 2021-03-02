using System;

namespace BST
{
    class BSTProgram
    {
        static void Main(string[] args)
        {
            BST tree = new BST(10);
            tree.Add(12);
            tree.Add(11);
            tree.Add(17);
            tree.Add(6);

            Console.WriteLine(tree.FirstElement());
        }
    }
}
