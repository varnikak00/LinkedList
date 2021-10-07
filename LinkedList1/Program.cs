using System;
using System.Collections.Generic;

namespace LinkedList1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddFirst(56);
            ll.AddFirst(30);
            ll.AddFirst(70);

            foreach (int ele in ll)
            {
                Console.WriteLine("The linked list elements are : " + ele);

            }
        }
    }
}
