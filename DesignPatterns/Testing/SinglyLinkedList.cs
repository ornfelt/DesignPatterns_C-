using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Testing
{
    public class SinglyLinkedList
    {
        public class Node
        {
            // link to next Node in list
            public Node next = null;
            // value of this Node
            public object data;
        }

        private Node root = null;

        public Node First { get { return root; } }

        public Node Last 
        {
            get
            {
                Node curr = root;
                if (curr == null)
                    return null;
                while (curr.next != null)
                    curr = curr.next;
                return curr;
            }
        }

        public void Append(object value)
        {
            Node n = new Node { data = value };
            if (root == null)
                root = n;
            else
                Last.next = n;
        }

        public void Delete(Node n)
        {
            if (root == n) 
            {
                root = n.next;
                n.next = null;
            }
            else
            {
                Node curr = root;
                while (curr.next != null)
                {
                    if (curr.next == n)
                    {
                        curr.next = n.next;
                        n.next = null;
                        break;
                    }
                    curr = curr.next;
                }
            }
        }
    }
}
