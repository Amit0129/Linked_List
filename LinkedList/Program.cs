﻿namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating Project For LinkedList Program");

            LinkedList myLinkedList = new LinkedList();
            myLinkedList.Add(30);
            myLinkedList.Add(56);
            myLinkedList.Add(70);
            myLinkedList.Add(10);
            myLinkedList.Add(20);
            myLinkedList.Add(40);
            myLinkedList.InserttoLnkLst(5, 69);
            myLinkedList.DiaplayLnkLst();
        }
    }
}