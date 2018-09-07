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

      Console.WriteLine("the lenght of linkedList is " + linklist.LengthOfLinkedList());

      linklist.PrintAllNode();

      Console.WriteLine("get node at index" + linklist.GetNodeAtIndex(4).value);

      Console.WriteLine("the value of lastnode is " + linklist.GetLastNode().value);

      Console.WriteLine("the node before index 3 is " + linklist.GetNodeBeforeIndex(3));

      Console.WriteLine("THE NODE AFTER INDEX " + linklist.GetNodeAfterIndex(3));

      linklist.DeleteNodeByIndex(2);
      linklist.PrintAllNode();
      Console.WriteLine("the lenght of linkedList is " + linklist.LengthOfLinkedList());

      Console.WriteLine("get node at index" + linklist.GetNodeAtIndex(4).value);

      Console.ReadLine();// to pause the output

    }

  }
}
