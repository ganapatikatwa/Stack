using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class QueueEx
    {
        Node front;
        Node rear;
        public void Enqueue(int data)
        {
            Node newnode = new Node(data);
            if (front == null)
            {
                rear = newnode;
                front = rear;
            }
            else
            {
                rear.Next = newnode;
                rear= rear.Next;
            }
        }

        public void Dequeue()
        {
            if(this.front==null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                while(this.front!=null)
                {
                    Console.WriteLine("{0} is the Deleted Element in the Queue--",this.front.Data);
                    this.front = this.front.Next;
                }
            }
        }
        public void DisplayQueue()
        {
            
            if(front==null)
            {
                Console.WriteLine("Queue is Empty");
            }
            Node temp = front;
                while(temp!=null)
                {
                    Console.WriteLine(" | "+temp.Data+" | ");
                    temp=temp.Next;
                }
        }

    }
}
