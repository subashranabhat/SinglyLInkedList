using System;
using SinglyLinkedListImplementation;

namespace LinkedListImplementation
{
  class Program
  {
    static void Main(string[] args)
    {
      LinkedList linklist = new LinkedList();
      linklist.AddNode(20);//0
      linklist.AddNode(34);//1
      linklist.AddNode(100);//2
      linklist.AddNode(3945);//3
      linklist.AddNode(555);//4
      linklist.AddNode(44);

      linklist.LengthOfLinkedList();
      Console.WriteLine("**************************************************************");

      linklist.DeleteNodeByIndex(2);
      linklist.PrintAllNode();

      linklist.InsertNodeAfterIndex(3,888);
      linklist.PrintAllNode();
     linklist.LengthOfLinkedList();

      linklist.InsertNodeBeforeIndex(0, 121);
      linklist.PrintAllNode();
      linklist.LengthOfLinkedList();

      Console.ReadLine();// to pause the output

    }

  }
}
