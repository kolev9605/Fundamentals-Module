namespace AvlTreeLab
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            AvlTree<int> tree = new AvlTree<int>();

            tree.Add(3);
            tree.Add(-2);
            tree.Add(10);
            tree.Add(-10);
            tree.Add(9);
            tree.Add(20);
            tree.Add(30);
            tree.Add(19);
            tree.Add(15);


            Console.WriteLine();
        }
    }
}
