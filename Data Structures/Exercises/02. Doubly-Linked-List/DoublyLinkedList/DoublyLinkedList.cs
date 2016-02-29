﻿namespace Double_Linked_List
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        public class ListNode<T>
        {
            public ListNode(T value)
            {
                this.Value = value;
            }

            public T Value { get; private set; }

            public ListNode<T> NextNode { get; set; }

            public ListNode<T> PrevNode { get; set; }
        }

        private ListNode<T> head;
        private ListNode<T> tail;

        public int Count { get; private set; }

        public void AddFirst(T element)
        {
            ListNode<T> newNode = new ListNode<T>(element);

            if (this.Count == 0)
            {
                this.head = newNode;
                this.tail = newNode;
            }
            else
            {
                newNode.NextNode = this.head;
                this.head.PrevNode = newNode;
                this.head = newNode;
            }

            this.Count++;
        }

        public void AddLast(T element)
        {
            ListNode<T> newNode = new ListNode<T>(element);

            if (this.Count == 0)
            {
                this.head = newNode;
                this.tail = newNode;
            }
            else
            {
                newNode.PrevNode = this.tail;
                this.tail.NextNode = newNode;
                this.tail = newNode;
            }

            this.Count++;
        }

        public T RemoveFirst()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("List is empty");
            }

            var value = this.head.Value;
            this.head = this.head.NextNode;
            if (this.head != null)
            {
                this.head.PrevNode = null;
            }
            else
            {
                this.tail = null;
            }

            this.Count--;
            return value;
        }

        public T RemoveLast()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("List is empty");
            }

            var value = this.tail.Value;
            this.tail = this.tail.PrevNode;
            if (this.tail != null)
            {
                this.tail.NextNode = null;
            }
            else
            {
                this.head = null;
            }

            this.Count--;
            return value;
        }

        public void ForEach(Action<T> action)
        {
            var currentNode = this.head;
            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.NextNode;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var node = this.head;
            while (node != null)
            {
                yield return node.Value;
                node = node.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public T[] ToArray()
        {
            T[] array = new T[this.Count];
            int index = 0;
            var node = this.head;
            while (node != null)
            {
                array[index] = node.Value;
                index++;
                node = node.NextNode;
            }

            return array;
        }
    }

    class Example
    {
        static void Main()
        {
            var list = new DoublyLinkedList<int>();

            list.ForEach(Console.WriteLine);
            Console.WriteLine("--------------------");

            list.AddLast(5);
            list.AddFirst(3);
            list.AddFirst(2);
            list.AddLast(10);
            Console.WriteLine("Count = {0}", list.Count);

            list.ForEach(Console.WriteLine);
            Console.WriteLine("--------------------");

            list.RemoveFirst();
            list.RemoveLast();
            list.RemoveFirst();

            list.ForEach(Console.WriteLine);
            Console.WriteLine("--------------------");

            list.RemoveLast();

            list.ForEach(Console.WriteLine);
            Console.WriteLine("--------------------");
        }
    }
}