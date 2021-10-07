using System;
using System.Collections.Generic;

namespace LinkedList4
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList<int> ll = new LinkedList<int>();
            ll.AddFirst(70);
            ll.AddFirst(56);


            foreach (int ele in ll)
            {
                Console.Write(" " + ele + " ");
                Console.WriteLine("-------");
            }

            LinkedListNode<int> node = ll.Find(70);
            ll.AddBefore(node, 30);
            foreach (int ele in ll)
            {
                Console.Write(" " + ele + " ");
            }
        }
    }
}
