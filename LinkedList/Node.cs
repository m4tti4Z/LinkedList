using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist
{
    public class Node<T>
    {
        public T Data { get; set; }

        public Node<T> Next;


        public Node(T dato) {
        
            Data = dato;
            Next = null;
        }
        public override string ToString()
        {
            return Data.ToString();
        }

    }
    }

