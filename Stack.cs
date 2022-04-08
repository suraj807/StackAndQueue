﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    internal class Stack<T>
    {
        CustomLinkedList<T> list = new CustomLinkedList<T>(); // Creating object of Linked List generic class
        private Node<T> top; // Creating variable to maintain Top of stack
        public void Push(T data) // Creating method to push element in Stack
        {
            Node<T> newNode = new Node<T>(data); // Creating a new node for data which is passed by user
            if (this.top == null) // Checking that top is null
            {
                newNode.next = null; // If top is null then new node pointing to null
            }
            else
            {
                newNode.next = this.top; // If top is not null then new node is pointing where top is
            }
            this.top = newNode; // Making newnode as top of stack
            Console.WriteLine($"\n{data} is pushed into stack");
        }
        public void Display() // Creating method to display element in Stack
        {
            Node<T> temp = this.top; // Storing top of stack to temp node
            if (temp == null) // Checking that stack is empty or not
            {
                Console.WriteLine("\nStack is empty");
            }
            else
            {
                //If stack is not empty then print all the element one by one
                Console.WriteLine("\nAll the element of stack from top to bottom are : ");
                while (temp != null)
                {
                    Console.WriteLine($"{temp.data} ");
                    temp = temp.next;
                }
            }
        }
        public void PushByLinkedList(T data) // Creating method to push element in Stack using linked list
        {
            list.AddFirst(data); // Calling addFirst method of linkedlist class to push element in stack
            Console.WriteLine($"\n{data} is pushed into stack using Linked List");
        }
        public void DisplayByLinkedList() // Creating method to display element in Stack using linked list
        {
            this.top = list.top;
            Display();
        }
    }


}
