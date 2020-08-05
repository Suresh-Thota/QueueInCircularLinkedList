using System;
using System.Collections.Generic;
using System.Text;

namespace QueueInCircularLinkedList
{
    class Demo
    {
        static void Main(String[] args)
        {
            int choice, x;
            QueueC queue = new QueueC();
            while (true)
            {
                Console.WriteLine("1. Insert an element in the queue");
                Console.WriteLine("2. Delete an element from the queue");
                Console.WriteLine("3.Display element at the front");
                Console.WriteLine("4.Display all elements from the queue");
                Console.WriteLine("5.Display size of the queue");
                Console.WriteLine("6.quit");
                Console.Write("enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 6)
                {
                    break;
                }
                switch (choice)
                {
                    case 1:
                        Console.Write("enter the element to be inserted");
                        x = Convert.ToInt32(Console.ReadLine());
                        queue.Insert(x);
                        break;
                    case 2:
                        x = queue.Delete();
                        Console.WriteLine("Deleted element is " + x);
                        break;
                    case 3:
                        Console.WriteLine("element at the front is " + queue.Peek());
                        break;
                    case 4:
                        queue.Display();
                        break;
                    case 5:
                        Console.WriteLine("Size of the queueu is" + queue.Size());
                        break;
                    default:
                        Console.WriteLine("wrong choice");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
