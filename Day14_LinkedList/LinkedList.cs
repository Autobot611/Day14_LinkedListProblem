﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_LinkedList
{
    public class LinkedList
    {
        public Node head;
        public Node tail;

        public void Add(int data)
        {

            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }

            Console.WriteLine("{0} is added into Linked List", node.data);
        }
        public void Insert(int data, int previous)
        {

            Node newNode = new Node(data);
            if (head == null & tail == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;

                while (temp.data != previous)
                {
                    temp = temp.next;
                }
                newNode.next = temp.next;
                temp.next = newNode;
            }
            Console.WriteLine("{0} is inserted into Linked List", newNode.data);
        }
        public void Append(int data)
        {

            Node node = new Node(data);

            if (head == null & tail == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                Node temp = head;

                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} is appended into Linked List", node.data);
        }

        public void InsertNode(int value, int Previousvalue)
        {
            Node newNode = new Node(value);
            if (head == null & tail == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;

                while (temp.data != Previousvalue)
                {
                    temp = temp.next;
                }
                newNode.next = temp.next;
                temp.next = newNode;
            }
            Console.WriteLine("Added at in between: " + value);
        }
        public void DeleteNodeAtFirst()
        {
            {
                if (head == null & tail == null)
                {
                    Console.WriteLine("Nothing to delete list is empty");
                }
                Node temp = head;

                head = head.next;

                Console.WriteLine("Removed from linkedlist :" + temp.data);
            }
        }

        public void PopLast()
        {
            {

                if (head == null & tail == null)
                {
                    Console.WriteLine("Nothing to delete list is empty");

                }

                Node temp = head;

                while (temp.next.next != null)
                {

                    temp = temp.next;
                }

                temp.next = null;
            }
        }

        public bool Search(int value)
        {
            {

                Node temp = head;

                while (temp != null)
                {

                    if (temp.data == value)
                    {
                        return true;
                    }
                    temp = temp.next;
                }
                return false;
            }
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + "");
                temp = temp.next;

            }

        }
        public void deleteNode(int value)
        {

            Node temp = head, prev = null;


            if (temp != null && temp.data == value)
            {

                head = temp.next;
                return;
            }


            while (temp != null && temp.data != value)
            {
                prev = temp;
                temp = temp.next;
            }


            if (temp == null)
                return;
            prev.next = temp.next;

        }
        public void sort()
        {
            Node i, j;
            int temp;
            for (i = this.head; i.next != null; i = i.next)
            {
                for (j = i.next; j != null; j = j.next)
                {
                    if (i.data > j.data)
                    {
                        temp = i.data;
                        i.data = j.data;
                        j.data = temp;
                    }
                }
            }
        }
    }
}