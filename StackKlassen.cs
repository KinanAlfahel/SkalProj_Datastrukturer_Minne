using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne
{
    public class StackKlassen
    {
        private string UserInput { get; set; }

        public Stack<char> MyStack { get; set; }

        public StackKlassen(string userInput)
        {
            MyStack = new Stack<char>();
            UserInput = userInput;
            foreach (var item in userInput)
            {
                MyStack.Push(item);
            }
        }

        public void ReverseText()
        {
            while (MyStack.Count > 0)
            {
                Console.Write(MyStack.Pop());
            }
        }
    }
}
