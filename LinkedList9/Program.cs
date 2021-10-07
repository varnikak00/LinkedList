using System;
using System.Collections.Generic;

namespace LinkedList9
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
            Console.WriteLine("Enter the Key to Search");
            int key = int.Parse(Console.ReadLine());
            int count = 0;
            int flag = 0;

            foreach (int ele in ll)
            {
                if (ele == key)
                {
                    Console.WriteLine("key found at position : " + count);
                    flag = 1;
                    LinkedListNode<int> node = ll.Find(key);
                    ll.AddAfter(node, 40);
                    break;

                }
                count++;
            }
            if (flag == 1)
            {
                foreach (int ele in ll)
                {
                    Console.Write(" " + ele + " ");
                }
                Environment.Exit(0);
            }

            Console.WriteLine("key not found");



        }

    }
}
