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

      int x = linklist.LengthOfLinkedList();
      Console.WriteLine("the lenght of linkedList is " + x);

      linklist.PrintAllNode();
      
      Node y = linklist.GetLastNode();
      Console.WriteLine("the value of lastnode is " + y.value);

     // Console.WriteLine("the value of node at index x " + linklist.GetNode(100));

      Console.WriteLine("the node before index 3 is " + linklist.GetNodeBeforeIndex(3));

     Console.WriteLine("THE NODE AFTER INDEX " + linklist.GetNodeAfterIndex(3));

      linklist.DeleteNodeByIndex(2);
      linklist.PrintAllNode();
       Console.WriteLine("the lenght of linkedList is " + linklist.LengthOfLinkedList());
      Console.ReadLine();// to pause the output
      
    }

  }
}
