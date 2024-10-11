using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TestAddLastData();
            TestAddLastNode();
            TestAddAfterNode();
            TestAddafterData();
            TestAddbeforeNode();
            TestAddbeforeData();
            TestAddfirstNode();
            TestAddFirstData();

            Console.ReadKey();
        }



        static void TestAddLastData()
        {
            ClinkedList<string> list1 = new ClinkedList<string>();
            string[] words = { "AAA", "BBB", "CCCCC" };
            string[] arr = new string[words.Length];

            for(int i = 0; i < words.Length; i++)
            {
                list1.AddLast(words[i]);
                arr[i] = words[i];
                Console.WriteLine("Test add last (data) : " + list1.ToString());

            }

            Node<string> current = list1.Head;
            bool corretto = true;
            
            for(int i = 0; i < arr.Length; i++)
            {
                if(current == null || !arr[i].Equals(current.Data)){
                    corretto = false;

                }
                current = current.Next;
            }
            if (corretto)
            {
                Console.WriteLine("Inserimento corretto");
            }
            else
            {
                Console.WriteLine("Inserimento non corretto");
            }
            
        }
        static void TestAddLastNode()
        {
            ClinkedList<string> list1 = new ClinkedList<string>();
            string[] words = { "Hello", "Let'see if it works", "I hope so" };
            string[] arr = new string[words.Length]; 

            for(int i = 0; i < words.Length; i++)
            {
                Node<string> newNode = new Node<string>(words[i]);
                list1.AddLast(newNode);
                arr[i] = newNode.ToString();
            }
            Console.WriteLine("Test add last(Node)" + list1.ToString());
            bool corretto = true;
            Node<string> current = list1.Head;

            for(int i = 0; i < arr.Length; i++)
            {
                if (current == null || !current.Data.Equals(words[i]))
                {
                    corretto = false;
                    
                }
                current = current.Next;
               
            }
            if (corretto)
            {
                Console.WriteLine("Inserimento corretto");
            }
            else { Console.WriteLine("Inserimento non corretto"); }



        }

    

        static void TestAddAfterNode()
        {
            ClinkedList<int> list1 = new ClinkedList<int>();
            int[] numbers = { 1, 2, 3, 45, 6776, 3 };
            Node<int> first = new Node<int>(2);
            list1.AddLast(first);

            for(int i = 0;i<numbers.Length;i++) {

                Node<int> newNode = new Node<int>(numbers[i]);
                list1.AddAfter(first, newNode);
                first = newNode;
            }

            Console.WriteLine("Test add After(node) : " + list1.ToString());

        }
        static void TestAddafterData()
        {
            ClinkedList<char> list1 = new ClinkedList<char>();
            char[] chars = { 'a', 'b', 'c', };
            Node<char> first = new Node<char>('z');
            list1.AddLast(first);

            for(int i = 0; i < chars.Length; i++)
            {
                list1.Addafter(first, chars[i]);
            }
            Console.WriteLine("Test add after data : " + list1.ToString());
        }
        static void TestAddbeforeNode()
        {
            ClinkedList<bool> list1 = new ClinkedList<bool>();
            bool[] bools = { true, false, true, true, false };
            Node<bool> first = new Node<bool>(true);
            list1.AddLast(first);

            for(int i = 0; i < bools.Length; i++)
            {
                Node<bool> newNode = new Node<bool>( bools[i] );
                list1.AddBefore(first, newNode);
                first = newNode;
                //expected output:list read reverse
            }

            Console.WriteLine("Test add before node : " + list1.ToString());
        }
        static void TestAddbeforeData()
        {
            ClinkedList<int> list1 = new ClinkedList<int>();
            int[] numbers = { 18,33,45,11,21,123,44,5 };
            Node<int> first = new Node<int>(69);
            list1.AddLast(first);

            for (int i = 0; i < numbers.Length; i++)
            {
               list1.AddBefore(first, numbers[i]);
            }

            Console.WriteLine("Test add beofre data : " + list1.ToString());
        }
        static void TestAddfirstNode()
        {
            ClinkedList<decimal> list = new ClinkedList<decimal>();
           decimal[] numbers  = { 3.13M, 3.111M, 3.22M };

            for(int i = 0; i < numbers.Length; i++)
            {
                Node<decimal> newNode = new Node<decimal>(numbers[i]);
                list.Addfirst(newNode);

            }
            Console.WriteLine("Test add first node : "+ list.ToString());
        }
        static void TestAddFirstData()
        {
            ClinkedList<string> list = new ClinkedList<string>();
            string[] phrases = { "Hello", "See you", "Have a nice day" };
            
            for(int i = 0; i < phrases.Length; i++)
            {
                list.Addfirst(phrases[i]);
            }
            Console.WriteLine("Test addFirst data :" + list.ToString());
        }
    }
}
