using System;
using System.Collections.Generic;

namespace LinkedList7
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
            foreach (int ele in ll)
            {
                if (ele == key)
                {
                    Console.WriteLine("key found at position : " + count);
                    Environment.Exit(0);

                }
                count++;
            }


            Console.WriteLine("key not found");
        }
    }
}
