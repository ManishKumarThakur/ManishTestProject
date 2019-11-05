using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNDVS2017_ConsoleApp
{
    public class SingleLinkedList1
    {
        private Node1 head;

        public void AddFirstNode(SingleLinkedList1 singleLinkList, int data)
        {
            Node1 node = new Node1(data);
            node.next = singleLinkList.head;
            singleLinkList.head = node;
        }

        public void InsertLastNode(SingleLinkedList1 singleLinkedList, int data)
        {
            Node1 NewNode = new Node1(data);

            if (singleLinkedList.head == null)
            {
                singleLinkedList.head = NewNode;
                return;
            }

            Node1 LastNode = FindLastNode(singleLinkedList);
            LastNode.next = NewNode;
        }

        public void InsertAfter(Node1 PreviousNode, int data)
        {
            Node1 insertedNode = new Node1(data);

            insertedNode.next = PreviousNode.next;
            PreviousNode.next = insertedNode;
        }

        public void DeleteNode(SingleLinkedList1 singleLinkedList, int key)
        {
            Node1 delNode = new Node1(key);
            delNode.next = singleLinkedList.head;
            Node1 preNode = null;

            while (delNode.next != null && delNode.data != key)
            {
                preNode = delNode;
                delNode = delNode.next;
            }

            preNode.next = delNode.next;
        }

        public void ReverseNode(SingleLinkedList1 singleLinkedList)
        {
            Node1 prev = null;
            Node1 current = singleLinkedList.head;
            Node1 temp = null;

            while (current != null)
            {
                temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }
        }

        public Node1 FindLastNode(SingleLinkedList1 singleLinkedList)
        {
            Node1 node = singleLinkedList.head;

            while (head.next != null)
            {
                node = node.next;
            }

            return node;
        }
    }
}
