using Stack;
using System;
using System.Collections.Generic;

namespace LinkedList
{
    public class Program
    {
        public static void Main(String[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the Choice\n1)Stack\n2)Pop and Peek\n3)Enqueue\n4)Dequeue");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        StackEx ex = new StackEx();
                        ex.Push(70);
                        ex.Push(30);
                        ex.Push(56);
                        ex.Display();
                        break;
                    case 2:
                        //StackEx ex = new StackEx();
                        //ex.Push(70);
                        //ex.Push(30);
                        //ex.Push(56);
                        //ex.Display();
                        //ex.Pop();
                        //ex.Pop();
                        //ex.Pop();
                        //ex.Display();
                        //ex.Peek();
                        //ex.Display();
                        //break;
                    case 3:
                        QueueEx qx =new QueueEx();
                        qx.Enqueue(56);
                        qx.Enqueue(30);
                        qx.Enqueue(70);
                        qx.DisplayQueue();
                        break;
                    case 4:
                        QueueEx qx = new QueueEx();
                        qx.Enqueue(56);
                        qx.Enqueue(30);
                        qx.Enqueue(70);
                        qx.DisplayQueue();
                        qx.Dequeue();
                        qx.DisplayQueue();
                        break;
                }
               
            
            }
        }
    }
}
