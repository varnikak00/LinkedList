using System;
using System.Collections.Generic;

namespace LinkedList3
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddFirst(56);


            foreach (int ele in ll)
            {
                Console.WriteLine("The linked list elements are : " + ele);
                Console.WriteLine("------------");
            }

            ll.AddLast(30);
            ll.AddLast(70);


            foreach (int ele in ll)
            {
                Console.WriteLine("The linked list elements are : " + ele);
            }
        }
    }
}
