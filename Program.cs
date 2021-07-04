using System;
using System.Collections.Generic;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ex1");
            Listklassen<int> myListClass = new Listklassen<int>();

            Console.WriteLine("Current capacity: " + myListClass.ExamineList());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ex2");
            QueueKlassen<string> queueKlassen = new QueueKlassen<string>();

            queueKlassen.AddElement("Kalle");
            queueKlassen.AddElement("Greta");
            queueKlassen.RemoveElement();
            queueKlassen.AddElement("Stina");
            queueKlassen.RemoveElement();
            queueKlassen.AddElement("Olle");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ex3");
            Console.WriteLine("Please enter a string to be reversed by the stack:");
            StackKlassen stackKlassen = new StackKlassen(Console.ReadLine());
            stackKlassen.ReverseText();


        }

    }
}
