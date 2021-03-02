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
            tree.Add(14);
            tree.DoesTreeContain(11);

            Console.WriteLine(tree.FirstElement()); // 6  
            Console.WriteLine(tree.LastElement()); // 17
            Console.WriteLine(tree.DoesTreeContain(11)); // True
        }
    }
}
