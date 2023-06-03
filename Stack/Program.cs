using Stack;
using System;
namespace LinkedList
{
    public class Program
    {
        public static void Main(String[] args)
        {
            StackEx ex = new StackEx();
            ex.Push(70);
            ex.Push(30);
            ex.Push(56);
            ex.Display();
            Console.WriteLine("\n\n");
            //ex.Pop();
            //ex.Pop();
            //ex.Pop();
            //ex.Display();
            ex.Peek();
            ex.Display();

        }
    }
}
