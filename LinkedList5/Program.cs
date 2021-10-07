using System;
using System.Collections.Generic;

namespace LinkedList5
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddFirst(70);
            ll.AddFirst(30);
            ll.AddFirst(56);

            Console.WriteLine("The linked list elements are:");
            foreach (int ele in ll)
            {
                Console.Write(" " + ele + " ");

            }
            Console.WriteLine();
            Console.WriteLine("------------");
            ll.RemoveFirst();
            Console.WriteLine("After removing first element");
            foreach (int ele in ll)
            {
                Console.Write(" " + ele + " ");

            }
        }
    }
}
