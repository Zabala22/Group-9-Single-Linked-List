using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    public class Node <T>
    {
        //Data of the node that we are trying to store
        public T Data { get; set; } 

        //Link that connects to the next node
        public Node<T> Next { get; internal set; }

        //constructor
        public Node(T data)
        {
            this.Data = data;
        }
    }
}
