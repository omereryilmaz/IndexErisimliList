using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_AA
{

    public class omrList
    {

        public class Node
        {
            public object NodeContent;
            public Node Next;
        }

        private int size;
        public int Count
        {
            get
            {
                return size;
            }
        }

        private Node head;
        private Node current;

        public omrList()
        {
            size = 0;
            head = null;
        }


      
        public void Add(object content)
        {
            size++;

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

        
        //tum listeyi yazdir
        public void ListNodes()
        {
            Node tempNode = head;

            while (tempNode != null)
            {
                Console.WriteLine(tempNode.NodeContent);
                tempNode = tempNode.Next;
            }
        }


        //liste yapisina indexle erisim fonksiyonu
        public void indexliErisim(int index)
        {
            Node tempNode = head;
            if (index == 0)
            {
                Console.Write(tempNode.NodeContent);
            }
            else
            {
                for (int i = 0; i < index; i++)
                {
                    tempNode = tempNode.Next;
                }
                Console.Write(tempNode.NodeContent);
            }

            
            

            
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            omrList listem = new omrList();
            listem.Add(3);
            listem.Add(6);
            listem.Add(9);
            listem.Add(12);
            listem.ListNodes();
            Console.Write("Sadece 1. elemani goster : ");
            listem.indexliErisim(0);
            Console.ReadKey();

        }
    }
}
