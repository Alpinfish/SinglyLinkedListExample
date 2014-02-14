using System;


namespace SinglyLinkedListExample
{
    class SinglyLinkedList
    {

        private Node head;
        private Node current;
        public int Size { get; set; }

        public class Node
        {
            public object NodeContent;
            public Node Next;
        }

        public SinglyLinkedList()
        {
            Size = 0;
            head = null;
        }



        public void PrintLinkedListContent()
        {
            Node tempNode = head;

            while (tempNode != null)
            {
                Console.Write(tempNode.NodeContent);
                tempNode = tempNode.Next;
            }
        }

        public void Add(object content)
        {
            Size++;
            var node = new Node()
            {
                NodeContent = content
            };

            if (head == null)
            {
                head = node;
            }
            else
            {
                current.Next = node;
            }

            current = node;
        }

        public void Delete(int position)
        {
            Node previousNode = null;
            Node currentNode = head;

            int count = 1;
            while (currentNode != null)
            {
                while (count <= Size)
                {
                    if (count == position)
                    {
                        if (previousNode == null)
                        {
                            head = currentNode.Next;
                            current = null;
                        }
                        else
                        {
                            previousNode.Next = currentNode.Next;
                            currentNode = null;                            
                        }
                    }
                    else
                    {
                        previousNode = currentNode;
                    }

                    if (currentNode != null)
                    {
                        currentNode = currentNode.Next;
                    }

                    count++;
                }
            }
        }

        public Node Retrieve(int Position)
        {
            Node tempNode = head;
            Node retNode = null;
            int count = 0;

            while (tempNode != null)
            {
                if (count == Position - 1)
                {
                    retNode = tempNode;
                    break;
                }
                count++;
                tempNode = tempNode.Next;
            }

            return retNode;
        }

    }
}
