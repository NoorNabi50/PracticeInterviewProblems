using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterviewProblems.LinkedList
{

    public class Node<T>
    {

        public T Data { get; set; }

        public Node<T> next { get; set; }

        public Node<T> head { get; set; }
        public Node(T name)
        {
            Data = name;
            next = null;
        }

        public Node()
        {

        }
        // Insert in LinkedList - either it is inserted in first position or Last Position

        public void AddFirst(T data)
        {
            Node<T> newNode = new(data);

            if (head == null)
            {
                head = newNode;
                return;
            }

            newNode.next = head;
            head = newNode;

        }

        public void AddLast(T data)
        {
            Node<T> newNode = new(data);

            if (head == null)
            {
                head = newNode;
                return;
            }
            Node<T> currNode = head;
            while (currNode.next != null)
            {
                currNode = currNode.next;
            }
            currNode.next = newNode;

        }


        public void DeleteFirst()
        {
            if (head == null)
            {
                Console.WriteLine("No node is available");
                return;
            }

            head = head.next;
        }

        public void DeleteLast()
        {
            if (head == null)
                Console.WriteLine("No node is available");
            Node<T> currNode = head;


        }


        public void ReverseLinkList()
        {

        }


        public void PrintList()
        {

            if (head == null)
                return;
            Node<T> currNode = head;
            while (currNode != null)
            {
                Console.Write(currNode.Data + " -> ");
                currNode = currNode.next;
            }

            Console.Write("NULL");
        }


        public void SearchElem(T elem)
        {
            Node<T> currNode = head;
            int i = 0;
            while(currNode !=null)
            {
                if(currNode.Data.Equals(elem))
                {
                    Console.WriteLine("\nElement {0} is found at index {1} ", elem, i);
                    break;
                }
                currNode = currNode.next;
                i++;
            }    
        }


       public void ConditionalNodesDelete()
        {


        }
    }



}
