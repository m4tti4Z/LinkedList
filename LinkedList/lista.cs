using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist
{
    public class ClinkedList<T>
    {
        public int Count;
        public Node<T> Head;
        public Node<T> Last;

        public ClinkedList()
        {
            //
        }
        public void InsertAfter(Node<T> existing, Node<T> newnode)
        {
            if (existing == null || newnode == null)
            {
                Console.WriteLine("Nodes cannot be null");
                return;
            }
            newnode.Next = existing.Next;
            existing.Next = newnode;
            if (existing == null)
            {
                Last = newnode;
            }
            Count++;

        }
        public void InsertBefore(Node<T> existing, Node<T> newnode)
        {
            if (existing == null || newnode == null)
            {
                Console.WriteLine("Nodes cannot be null");
                return;
            }

            if (existing == Head)
            {
                newnode.Next = Head;
                Head = newnode;
            }
            else
            {
                Node<T> current = Head;
                while (current != null && current.Next != existing)
                {
                    current = current.Next;
                }
                if (current != null)
                {
                    newnode.Next = existing;
                    current.Next = newnode;
                }
                if (newnode.Next == null)
                {
                    Last = newnode;
                }
                Count++;

            }
        }



        public void AddAfter(Node<T> existing, Node<T> newnode)
        {
            InsertAfter(existing, newnode);
        }
        public void Addafter(Node<T> existing, T data)
        {
            if (existing == null)
            {
                Console.WriteLine("Existing Node cannot be null");
                return;
            }
            Node<T> newnode = new Node<T>(data);
            InsertAfter(existing, newnode);

        }

        public void AddBefore(Node<T> existing, Node<T> newnode)
        {
            InsertBefore(existing, newnode);
            return;
        }

        public void AddBefore(Node<T> existing, T data)
        {
            if (existing == null)
            {
                Console.WriteLine("Existing Node cannot be null");
                return;
            }
            Node<T> newnode = new Node<T>(data);
            InsertBefore(existing, newnode);

        }
        public void Addfirst(Node<T> addingnode)
        {
            if (addingnode == null)
            {
                Console.WriteLine("Node cannot be null");
                return;
            }
            if (Head == null)//lista vuota
            {
                Head = addingnode;
                Last = addingnode;
            }
            else
            {
                addingnode.Next = Head;//punta al vecchio head
                Head = addingnode;//diventa il primo nodo 
            }
            Count++;
        }
        public void Addfirst(T data)
        {

            Node<T> newnode = new Node<T>(data);

            if (Head == null)
            {
                Head = newnode;
                Last = newnode;
            }
            else
            {
                newnode.Next = Head;//il nuovo nodo punta alla vecchia head quindi si mette prima 
                Head = newnode;//la head diventa il nuovo nodo ,quindi diventa primo elemento

            }
            Count++;
        }
        public void AddLast(Node<T> addingnode)
        {
            if (addingnode == null)
            {
                Console.WriteLine("Node cannot be null");
                return;
            }
            if (Head == null)
            {
                Head = addingnode;
                Last = addingnode;
            }
            else
            {
                Last.Next = addingnode;
                Last = addingnode;
            }
            Count++;
        }
        public void AddLast(T data)
        {

            Node<T> newnode = new Node<T>(data);

            if (Head == null)
            {
                Head = newnode;
                Last = newnode;
            }
            else
            {
                Last.Next = newnode;
                Last = newnode;

            }
            Count++;
        }
        public void Clear()
        {
            Head = null;
            Last = null;
            Count = 0;
        }
        public bool Contains(T data)
        {
            Node<T> current = new Node<T>(data);
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    return true;
                }
                current = current.Next;//il corrente diventa il successivo 
            }
            return false;
        }
        public Node<T> Find(T data)
        {

            Node<T> current = Head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    return current;
                }
                current = current.Next;
            }
            Console.WriteLine("Element not found");
            return null;
        }
        public Node<T> FindLast(T data)
        {
            Node<T> current = Head;
            Node<T> lastFound = null;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    lastFound = current;
                }
                current = current.Next;
            }
            return lastFound;
        }
        public void Remove(Node<T> toDelete)
        {
            //lista vuota
            if (Head == null)
            {
                Console.WriteLine("List is empty,noting to remove");
                return;
            }
            if (Head == toDelete)
            {
                Head = Head.Next;//se il nodo da eliminare è il primo,il secondo diventerè il primo

                if (Head == null)
                {
                    Last = null;//se la lista aveva un nodo,ora diventa vuota
                }
                return;
            }
            Node<T> current = Head;
            while (current.Next != null)
            {
                if (current.Next == toDelete)//se il nodo successivo è quello da rimuovere
                {
                    if (current.Next == Last)//se quello da rimuovere è ultimo
                    {
                        Last = current;//ultimo diventa quello corrente
                    }
                    current.Next = current.Next.Next;//il corrente punta a quello successivo a quello da eliminare
                    return;
                }
                current = current.Next;//aggiorno il corrente
            }
            Console.WriteLine("The node has not been found");

        }
        public void Remove(T data)
        {
            Node<T> toRemove = new Node<T>(data);

            //lista vuota
            if (Head == null)
            {
                Console.WriteLine("The list is empty");
                return;
            }
            //nodo da rimuovere è il primo
            if (Head.Data.Equals(toRemove.Data))
            {
                Head = Head.Next;
                if (Head == null) //se era da un elemento,diventa vuota
                {
                    Last = null;
                }
                return;
            }
            //ricerca della prima occorrenza
            Node<T> current = Head;
            while (current.Next != null)
            {
                if (current.Next.Data.Equals(data))
                {
                    if (current.Next == Last)
                    {
                        Last = current;//se il nodo rimosso era l ultimo
                    }
                }
                current.Next = current.Next.Next;//salto il nodo da rimuovere
                return;
            }
            current = current.Next;
            Console.WriteLine("The value " + data + " has not been found in the list");

        }

        public void RemoveFirst()
        {
            if (Head == null)
            {
                Console.WriteLine("The list is empty");
                return;
            }
            else if (Head.Next == null)
            {
                Head = null;//lista con solo un elemento
                Last = null;
            }
            else
            {
                Head = Head.Next;//passo al successivo
            }
            return;
        }

        public void RemoveLast()
        {
            if (Head == null)
            {
                Console.WriteLine("The list is empty");
                return;
            }
            else if (Head.Next == null)
            {
                Head = null;
                Last = null;

            }
            else
            {
                Node<T> current = Head;
                while (current.Next != Last)
                {
                    current = current.Next;
                }
                current.Next = null;
                Last = current;
            }
        }



        public override string ToString()
        {
            Node<T> current = Head;
            string result = "[";
            while (current != null)
            {
                result += current.ToString();
                current = current.Next;
                if (current != null)
                {
                    result += " -> ";
                }
            }
            result += "]";
            return result;
        }

    }
}
