using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //add after
            TestAddAfterNode();
            TestAddafterData();

            //add before
            TestAddbeforeNode();
            TestAddbeforeData();

            //add first
            TestAddfirstNode();
            TestAddFirstData();

            //add last
            TestAddLastData();
            TestAddLastNode();
            

            ClearTest();
            ContainsTest();
            FindTest();
            FindLastTest();


            //remove

            RemoveNodeTest();
            RemoveValueTest();
            RemoveFirstNode();
            RemoveLastNode();



            

     

           

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
  

            }
            Console.WriteLine("Test add last (data) : " + list1.ToString());

            Node<string> current = list1.Head;
            bool corretto = true;
            
            for(int i = 0; i < arr.Length; i++)
            {
                if(current == null || !arr[i].Equals(current.Data)){
                    corretto = false;
                    break;

                }
                current = current.Next;
            }

            if (corretto)
            {
                Console.WriteLine("Test passed");
            }
            else
            {
                Console.WriteLine("Test failed");
            }
            
        }
              
        static void TestAddLastNode()
        {
            Console.WriteLine("\n");



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
                    break;
                    
                }
                current = current.Next;
               
            }
            if (corretto)
            {
                Console.WriteLine("Test passed");
            }
            else { Console.WriteLine("Test failed");
            
            }

        }

    

        static void TestAddAfterNode()
        {

            Console.WriteLine("\n");


            ClinkedList<int> list1 = new ClinkedList<int>();
            int[] numbers = { 1, 2, 3, 45, 6776, 3 };

            Node<int> first = new Node<int>(numbers[0]);
            list1.AddLast(first);

            for(int i = 1;i<numbers.Length;i++) {

                Node<int> newNode = new Node<int>(numbers[i]);
                list1.AddAfter(first, newNode);
                first = newNode;
            }

            Console.WriteLine("Test add After(node) : " + list1.ToString());

            Node<int> current = list1.Head;
            bool corretto = true;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (current == null || current.Data != numbers[i])
                {
                    corretto = false;
                    break;  
                }
                current = current.Next; 
            }

            
            if (corretto)
            {
                Console.WriteLine("Test passed");
            }
            else
            {
                Console.WriteLine("Test failed");
            }
        }
        static void TestAddafterData()
        {
            Console.WriteLine("\n");

            ClinkedList<char> list1 = new ClinkedList<char>();
            char[] chars = { 'a', 'b', 'c', };
            Node<char> first = new Node<char>('z');
            list1.AddLast(first);

            for(int i = 0; i < chars.Length; i++)
            {
                list1.Addafter(first, chars[i]);
                first = first.Next;
            }
            Console.WriteLine("Test add after data : " + list1.ToString());

            Node<char> current = list1.Head;
            bool corretto = true;
            if(current == null || current.Data != first.Data)
            {
                corretto = false;

            }
            else
            {
                current = current.Next;
                for(int i = 0; i < chars.Length; i++)
                {
                    if(current == null || current.Data != chars[i])
                    {
                        corretto = false;
                        break;
                    }
                    current = current.Next;
                }
            }

            if (corretto)
            {
                Console.WriteLine("Test passed");
            }
            else
            {
                Console.WriteLine("Test failed");
            }
        }


        static void TestAddbeforeNode()
        {
            Console.WriteLine("\n");

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

            Node<bool> current = list1.Head;
            bool corretto = true;

            for(int i = bools.Length-1; i >= 0; i--)
            {
                if(current == null || current.Data!= bools[i])
                {
                    corretto = false;
                    break;
                }
                current = current.Next;
            }
            if(current == null || current.Data != bools[0])
            {
                corretto = false;
            }


            if (corretto)
            {
                Console.WriteLine("Test passed");
            }
            else
            {
                Console.WriteLine("Test failed");
            }
        }
        static void TestAddbeforeData()
        {
            Console.WriteLine("\n");

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
            Console.WriteLine("\n");


            ClinkedList<decimal> list = new ClinkedList<decimal>();
           decimal[] numbers  = { 3.13M, 3.111M, 3.22M };

            for(int i = 0; i < numbers.Length; i++)
            {
                Node<decimal> newNode = new Node<decimal>(numbers[i]);
                list.Addfirst(newNode);

            }

            Console.WriteLine("Test add first node : "+ list.ToString());
            bool corretto = true;

            if(list.Head.Data != numbers[numbers.Length - 1])
            {
                corretto = false;
            }
            else
            {
                corretto = true;
            }

            if (corretto)
            {
                Console.WriteLine("Test passed");
            }
            else
            {
                Console.WriteLine("Test failed");
            }
        }

        static void TestAddFirstData()
        {

            Console.WriteLine("\n");

            ClinkedList<string> list = new ClinkedList<string>();
            string[] phrases = { "Hello", "See you", "Have a nice day" };
            
            for(int i = 0; i < phrases.Length; i++)
            {
                list.Addfirst(phrases[i]);
            }
            Console.WriteLine("Test addFirst data :" + list.ToString());
            bool corretto = true;
            if(list.Head.Data != phrases[phrases.Length - 1])
            {
                corretto = false;
            }
            else
            {
                corretto = true;
            }

            if (corretto)
            {
                Console.WriteLine("Test passed");
            }
            else
            {
                Console.WriteLine("Test failed");
            }
        }

        static void ClearTest()
        {
            Console.WriteLine("\n");

            ClinkedList<string> newList = new ClinkedList<string>();

            string[] phrases = { "Dog", "Cat", "Lion" };

            for(int i = 0; i < phrases.Length; i++)
            {
                newList.AddLast(phrases[i]);
            }
            Console.WriteLine("List before clear : " + newList.ToString());

            bool corretto = true;

            newList.Clear();

            Console.WriteLine("List after clear : " + newList.ToString());
            if(newList.Head == null && newList.Count == 0)
            {
                corretto = true;
            }
            else
            {
                corretto = false;
            }
            if (corretto)
            {
                Console.WriteLine("Test passed");
            }
            else
            {
                Console.WriteLine("Test failed");
            }
        }
        static void ContainsTest()
        {
            Console.WriteLine("\n");

            ClinkedList<string> newList = new ClinkedList<string>();

            string[] phrases = { "ABC", "CDE", "YWJ" };

            for (int i = 0; i < phrases.Length; i++)
            {
                newList.AddLast(phrases[i]);
            }

            bool contiene = newList.Contains("ABC");
            bool contiene1 = newList.Contains("CCC");

          
          
            Console.WriteLine("The list is :" + newList.ToString());

            Console.WriteLine("Contains ABC : " + contiene);
            Console.WriteLine("Contains CCC: " + contiene1);
        }

        static void FindTest()
        {
            Console.WriteLine("\n");

            ClinkedList<string> newList = new ClinkedList<string>();

            string[] phrases = { "ABC", "CDE", "YWJ" };

            for (int i = 0; i < phrases.Length; i++)
            {
                newList.AddLast(phrases[i]);
            }
            Node<string> found1 = newList.Find("ABC");
            Node<string> found2 = newList.Find("CDE");
            Node<string> found3 = newList.Find("XYZ");

            Console.WriteLine("The list is :" + newList.ToString());
            Console.WriteLine("Found ABC : " + (found1 != null ? found1.Data : "Not found"));
            Console.WriteLine("Found CDE : " + (found2 != null ? found2.Data : "Not found"));
            Console.WriteLine("Found XYZ : " + (found3 != null ? found3.Data : "Not found"));
        }

        static void FindLastTest()
        {
            Console.WriteLine("\n");

            ClinkedList<string> newList = new ClinkedList<string>();

            string[] phrases = { "ABC", "CDE", "YWJ" };

            for (int i = 0; i < phrases.Length; i++)
            {
                newList.AddLast(phrases[i]);
            }
            Node<string> lastFoundNode = newList.FindLast("ABC");
            Node<string> notFoundNode = newList.FindLast("XYZ");

            Console.WriteLine("The list is :" + newList.ToString());
            Console.WriteLine("Last found ABC : " + (lastFoundNode!=null? lastFoundNode.Data :"Not found" ));
            Console.WriteLine("Last found ABC : " + (notFoundNode != null ? notFoundNode.Data : "Not found"));

        }
        static void RemoveNodeTest()
        {
            Console.WriteLine("\n");

            ClinkedList<string> newList = new ClinkedList<string>();

            string[] phrases = { "Tia", "Ivix", "Adam" };
            Node<string> nodeToRemove = null;

            for (int i = 0; i < phrases.Length; i++)
            {
                newList.AddLast(phrases[i]);
                if (phrases[i] == "Ivix")
                {
                    nodeToRemove = newList.Last;
                }

            }
            Console.WriteLine("The list is :" + newList.ToString());

            newList.Remove(nodeToRemove);
            Console.WriteLine($"List after removing '{nodeToRemove.Data}':" + newList.ToString());

            Node<string> fakeNode = new Node<string>("XYZ");
            newList.Remove(fakeNode); 
            Console.WriteLine("After trying to remove an inexistent node: " + newList.ToString());

        }
        static void RemoveValueTest()
        {
            Console.WriteLine("\n");

            ClinkedList<string> newList = new ClinkedList<string>();

            string[] phrases = { "Tia", "Ivix", "Adam" };
            
            for (int i = 0; i < phrases.Length; i++)
            {
                newList.AddLast(phrases[i]);
                
            }
            Console.WriteLine("The list is :" + newList.ToString());

            string valueToRem = "Adam";
            newList.Remove(valueToRem);
            Console.WriteLine($"After removing '{valueToRem}' : " + newList.ToString());

            string value1Torem = "Rimozione";
            newList.Remove(value1Torem);
            Console.WriteLine($"After removing '{value1Torem}' : " + newList.ToString());

        }
        static void RemoveFirstNode()
        {

        }

        static void RemoveLastNode()
        {

        }
    }
}
