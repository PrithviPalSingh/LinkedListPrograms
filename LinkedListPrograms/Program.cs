﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPrograms
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static void Print(Node head)
        {
            Node curr = head;
            while (curr != null)
            {
                Console.WriteLine(curr.Data);
                curr = curr.Next;
            }
        }

        public static void ReversePrint(Node head)
        {
            if (head == null)
            {
                return;
            }

            ReversePrint(head.Next);
            Console.WriteLine(head.Data);
        }

        public static Node Insert(Node head, int x)
        {
            Node curr = head;
            Node newNode = new Node();
            newNode.Data = x;
            newNode.Next = null;
            while (curr.Next != null)
            {
                curr = curr.Next;
            }

            curr.Next = newNode;
            return head;

        }

        public static Node InsertBeforeHead(Node head, int x)
        {
            Node node1 = new Node();
            node1.Data = x;
            node1.Next = head;
            return node1;
        }

        public static Node InsertNth(Node head, int data, int position)
        {
            Node curr = head;
            Node newNode = new Node();
            newNode.Data = data;
            newNode.Next = null;

            int tempPos = 0;

            if (curr != null)
            {
                if (position == 0)
                {
                    newNode.Next = head;
                    return newNode;
                }

                Node prev = head;
                while (tempPos != position)
                {
                    prev = curr;
                    curr = curr.Next;
                    tempPos++;
                }

                prev.Next = newNode;
                newNode.Next = curr;
            }
            else
            {
                curr = newNode;
            }

            return head;
        }


        public static Node Delete(Node head, int position)
        {
            Node curr = head;

            int tempPos = 0;

            if (curr != null)
            {
                if (position == 0)
                {
                    curr = curr.Next;
                    head = curr;
                }

                Node prev = head;
                while (tempPos != position)
                {
                    prev = curr;
                    curr = curr.Next;
                    tempPos++;
                }

                prev.Next = curr.Next;

            }
            else
            {

            }

            return head;
        }

        public static Node Reverse(Node head)
        {
            Node curr = head;
            Node prev = null;
            Node next = null;
            while (curr != null)
            {
                next = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = next;
            }

            head = prev;

            return head;
        }

        public static int CompareLists(Node a, Node b)
        {
            // This is a "method-only" submission.
            // You only need to complete this method.

            if (a != null && b != null)
            {
                while (a != null)
                {
                    if (a.Data != b.Data)
                    {
                        return 0;
                    }

                    a = a.Next;
                    b = b.Next;
                }
            }
            else
            {
                return 0;
            }

            if (a == null && b == null)
            {
                return 1;
            }

            return 0;
        }

        public static Node MergeLists(Node headA, Node headB)
        {
            // This is a "method-only" submission.
            // You only need to complete this method

            if (headA == null)
            {
                return headB;
            }

            if (headB == null)
            {
                return headA;
            }

            Node sortingPointer = null;

            if (headA.Data < headB.Data)
            {
                sortingPointer = headA;
                headA = headA.Next;
            }
            else
            {
                sortingPointer = headB;
                headB = headB.Next;
            }

            Node newHeaderNode = sortingPointer;

            while (headA != null && headB != null)
            {
                if (headA.Data <= headB.Data)
                {
                    sortingPointer.Next = headA;
                    sortingPointer = headA;
                    headA = headA.Next;                    
                }
                else
                {
                    sortingPointer.Next = headB;
                    sortingPointer = headB;
                    headB = headB.Next;
                }
            }

            if (headA != null)
            {
                sortingPointer.Next = headA;
            }

            if (headB != null)
            {
                sortingPointer.Next = headB;
            }

            return newHeaderNode;

        }

        public static int GetNode(Node head, int positionFromTail)
        {
            // This is a "method-only" submission.
            // You only need to complete this method.

            Node curr = head;
            Node item = head;
            int count = 0;

            while (curr != null)
            {
                curr = curr.Next;
                if (count > positionFromTail)
                {
                    item = item.Next;
                }

                count++;
            }

            return item.Data;
        }

    }

    class Node
    {
        public int Data;
        public Node Next;
    }
}
