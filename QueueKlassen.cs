using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne
{
    public class QueueKlassen<T>
    {
        public Queue<T> MyQueue;

        public QueueKlassen()
        {
            MyQueue = new Queue<T>();
            Console.WriteLine("The queue examination has started.");
            Console.WriteLine("The queue now is empty.");
        }

        public void AddElement(T element)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(element + " stands.");
            MyQueue.Enqueue(element);
        }

        public void RemoveElement()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(MyQueue.Peek() + " is out.");
            MyQueue.Dequeue();
        }
    }
}
