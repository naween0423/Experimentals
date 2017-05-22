using System;
using Experimental.BaseObjects;
using System.Collections.Generic;

namespace Experimental.LinkedLists
{
    /// <summary>
    /// LinkedLists
    /// </summary>
    public static class LinkedLists
    {

        /// <summary>
        /// Builds a Linked List
        /// </summary>
        /// <returns></returns>
        public static Node BuildLinkedList()
        {
            Node root = new Node(1);
            root.Next = new Node(2);
            root.Next.Next = new Node(3);
            root.Next.Next.Next = new Node(4);
            root.Next.Next.Next.Next = new Node(4);
            root.Next.Next.Next.Next.Next = new Node(6);
            root.Next.Next.Next.Next.Next.Next = new Node(4);
            root.Next.Next.Next.Next.Next.Next.Next = new Node(4);
            return root;
        }

        /// <summary>
        /// Check if a given LinkedLinks is a Palindron of itself.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static bool IsPalindrom(Node head)
        {
            if (head == null)
                return false;

            Node slow = head;
            Node fast = head;
            Stack<int> stack = new Stack<int>();
            while (fast != null && fast.Next != null)
            {
                stack.Push(slow.Data);
                slow = slow.Next;
                fast = fast.Next.Next;
            }
            
            if(fast != null)
            {
                slow = slow.Next;
            }

            while(slow != null)
            {
                int top = stack.Pop();

                if (top != slow.Data)
                    return false;
                slow = slow.Next;
            }
            return true;
        }

        /// <summary>
        /// Removes an element from a given position in a given List
        /// </summary>
        /// <param name="node"></param>
        /// <param name="position"></param>
        public static void RemovingInMiddle(Node node, int position)
        {
            Console.WriteLine("\n%%%%%%%%%%%%%%%%%%% Removing in the Middle %%%%%%%%%%%%%%%%%%%\n");
            var count = 1;
            var runner = node;
            while (runner != null)
            {
                if (count != position)
                {
                    count++;
                    runner = runner.Next;
                    continue;
                }
                runner.Next = runner.Next.Next;
                return;
            }
            return;
        }



        /// <summary>
        /// Adds an element in the middle\given position of a given List
        /// </summary>
        /// <param name="node"></param>
        /// <param name="newData"></param>
        /// <param name="position"></param>
        public static void AddInMiddle(Node node, int newData, int position)
        {
            Console.WriteLine("\n%%%%%%%%%%%%%%%%%%% Adding in the Middle %%%%%%%%%%%%%%%%%%%\n");
            var count = 0;
            var runner = node;
            while (runner != null)
            {
                if (count != position)
                {
                    count++;
                    runner = runner.Next;
                    continue;
                }
                var newNode = new Node
                {
                    Data = newData,
                    Next = runner.Next
                };
                runner.Next = newNode;
                return;
            }
        }

        /// <summary>
        /// Removes an element from the nack of a given List
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static Node RemoveBack(Node node)
        {
            Console.WriteLine("\n%%%%%%%%%%%%%%%%%%% Removing at Back %%%%%%%%%%%%%%%%%%%\n");
            if (node == null)
                return null;
            var previuos = node;
            var runner = node.Next;
            while (runner.Next != null)
            {
                previuos = runner;
                runner = runner.Next;
            }
            previuos.Next = null;

            return node;
        }

        /// <summary>
        /// Removes an element from the Front of a given List
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static Node RemoveFront(Node node)
        {
            Console.WriteLine("\n%%%%%%%%%%%%%%%%%%% Removing at Front %%%%%%%%%%%%%%%%%%%\n");
            if (node == null) return null;
            var temp = node;
            temp = temp.Next;
            node = temp;
            temp = null;

            return node;
        }

        /// <summary>
        /// Adds the element at the front of a given list.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="newData"></param>
        /// <returns></returns>
        public static Node AddFront(Node node, int newData)
        {
            Console.WriteLine("\n%%%%%%%%%%%%%%%%%%% Adding at Front %%%%%%%%%%%%%%%%%%%\n");
            var newnode = new Node { Data = newData };
            if (node != null)
            {
                newnode.Next = node;
                return newnode;
            }
            newnode.Next = null;
            return newnode;
        }

        /// <summary>
        /// Adds an element at the bak of a given List
        /// </summary>
        /// <param name="node"></param>
        /// <param name="newData"></param>
        public static void AddBack(Node node, int newData)
        {
            Console.WriteLine("\n%%%%%%%%%%%%%%%%%%% Adding at Back %%%%%%%%%%%%%%%%%%%\n");
            if (node == null) return;
            var runner = node;
            while (runner.Next != null)
            {
                runner = runner.Next;
            }
            var newnode = new Node { Data = newData };
            runner.Next = newnode;
            newnode.Next = null;
        }

        /// <summary>
        /// Prints the elements in a given List
        /// </summary>
        /// <param name="node"></param>
        public static void PrintNodes(Node node)
        {
            Console.WriteLine("\n%%%%%%%%%%%%%%%%%%% Printing Result %%%%%%%%%%%%%%%%%%%\n");
            if (node == null) return;
            var runner = node;
            while (runner.Next != null)
            {
                Console.WriteLine(runner.Data);
                runner = runner.Next;
            }
            Console.WriteLine(runner.Data);
        }

        /// <summary>
        /// Prints the Nth element from end
        /// retruns pointer to the nth element from End
        /// </summary>
        /// <param name="head"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static Node PrintNthNodeFromEnd(Node head, int n)
        {
            Console.WriteLine("\n%%%%%%%%%%%%%%%%%%% Printing nth element from End %%%%%%%%%%%%%%%%%%%\n");
            if (head == null)
                return null;
            Node current = head, target = head;
            for(var i = 1; i < n; i++)
            {
                if (current.Next != null)
                    current = current.Next;
                else
                    return null;
            }
            target = head;
            while(current.Next !=null)
            {
                current = current.Next;
                target = target.Next;
            }
            Console.WriteLine("{0} Node from the end is : {1}",n, target.Data);
            return target;
        }


        /// <summary>
        /// Reverse a Linked List
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static Node ReverseALinkedList(ref Node root)
        {
            if (root == null)
                return null;

            Node current = root;
            Node result = null;
            Node next;
            while(current != null)
            {
                next = current.Next;
                current.Next = result;
                result = current;
                current = next;
            }
            return result;
        }


        /// <summary>
        /// Removes Duplicates in a Linked List
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static Node RemoveDulplicates(Node root)
        {
            if (root == null)
                return null;

            Node prev = root;
            Node current = prev.Next;
            
            while(current != null)
            {
                Node runner = root;
                while (runner != current)
                {
                    if(current.Data == runner.Data)
                    {
                        Node temp = current.Next;
                        prev.Next = temp;
                        current = temp;
                        break;
                    }
                    runner = runner.Next;
                }
                if(runner == current)
                {
                    prev = current;
                    current = current.Next;
                }
            }
            return root;
        }

        /// <summary>
        /// Checks if there is a loop in the given LinkedList
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static bool CheckIfLoopExists(Node root)
        {
            if (root == null)
                return false;


            Node N1 = root;
            Node N2 = root;
            
            while(N2.Next != null)
            {
                N1 = N1.Next;
                N2 = N2.Next.Next;
                if (N1 == N2)
                    return true;
            }

            return false;
        }

        /// <summary>
        /// find the loop and returns the beginning of the loop
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static Node FindBeginning(Node root)
        {
            if (root == null)
                return null;

            Node N1 = root;
            Node N2 = root;

            while(N2.Next != null)
            {
                N1 = N1.Next;
                N2 = N2.Next.Next;
                if (N1 == N2)
                    break;
            }
            
            N1 = root;
            while(N1 != N2)
            {
                N1 = N1.Next;
                N2 = N2.Next;
            }
            return N1;
        }
    }
}
