using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList singlylinkedlist = new SinglyLinkedList();

            singlylinkedlist.Add("A");
            singlylinkedlist.Add("B");
            singlylinkedlist.Add("C");
            singlylinkedlist.Add("D");
            singlylinkedlist.Add("E");
            singlylinkedlist.Add("F");
            singlylinkedlist.Add("G");
            singlylinkedlist.Add("H");

            singlylinkedlist.PrintLinkedListContent();
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Deleting node 8");

            singlylinkedlist.Delete(8);

            Console.WriteLine();
            singlylinkedlist.PrintLinkedListContent();
            
            Console.WriteLine();
            Console.WriteLine(); 
            Console.WriteLine("Position 5: " + singlylinkedlist.Retrieve(5).NodeContent);

            
            Console.WriteLine();
            Console.WriteLine("Deleting node 1");

            singlylinkedlist.Delete(1);

            Console.WriteLine();
            Console.WriteLine("Position 5: " + singlylinkedlist.Retrieve(5).NodeContent);

            Console.WriteLine();
            singlylinkedlist.PrintLinkedListContent();

            Console.ReadLine();

        }
    }
}
