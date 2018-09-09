using System;
using System.Collections.Generic;
using System.Text;
using SinglyLinkedListImplementation;

namespace SinglyLinkedListImplementation
{
  public class LinkedList
  {
    public Node head { get; set; }
    public Node tail { get; set; }

    public LinkedList()
    {
      head = tail = null;
    }

    //public bool HasAnyNode()
    //{
    //    bool boolean = true;
    //    LinkedList ll = new LinkedList();
    //    if(head == null)
    //    {
    //        boolean = false;
    //    }
    //    return boolean;
    //}
    // the linked list cannot be null,i.e head cannot be null, since it returns a node
    public void AddNode(int n)
    {
      Console.WriteLine("adding node with value " + n);
      if (head == null)
      {
        head = new Node();
        head.value = n;
        head.next = null;
      }
      else
      {
        tail = GetLastNode();
        //creating reference and adding value for new Node that attaches to the end.
        Node newlyAddedNode = new Node();
        tail.next = newlyAddedNode;

        tail = newlyAddedNode;
        tail.value = n;
        tail.next = null;
      }
    }

    public void DeleteNodeByIndex(int index)
    {
      Console.WriteLine("deleting node at index " + index);
      // index has to be greater than 0 and less than length
      if (index == 0)
      {
        this.head.next = this.head; // new head
        this.head = null; //
      }
      else if (index == LengthOfLinkedList() - 1)
      {
        tail = GetLastNode();
        tail = null;
      }
      else
      {
        Node nodebefore = GetNodeBeforeIndex(index);
        Node nodeAfter = GetNodeAfterIndex(index);
        nodebefore.next = nodeAfter;
      }

    }

    public int LengthOfLinkedList()
    {
      int lenght = 1;
      if (head == null)
      {
        return 0;
      }
      else
      {
        //Console.WriteLine(head.value);
        Node temp = head;


        while (temp.next != null)
        {
          lenght = lenght + 1;
          temp = temp.next;
          // Console.WriteLine(head.value);
        }
      }

      return lenght;

    }

    //public int GetNode(int data)
    //{
    //  while (this.head.value != data)
    //  {
    //    this.head = this.head.next;
    //  }
    //  return head.value;
    //}

    public Node GetLastNode()
    {

      if (head == null)
      {
        head = tail = new Node();
      }
      else
      {
        Node temp = new Node();
        temp = head;
        while (temp.next != null)
        {
          temp = temp.next;
        }
        tail = temp;
      }

      return tail;
    }

    ////get nth node
    //public static int GetNthNode(int nthNode)
    //{
    //  var index = 0;

    //  if(nthNode == 0)
    //  {        
    //    return head.value;
    //  }
    //  else
    //  {
    //    while ( index != nthNode)
    //    {
    //      head = head.next;
    //      ++index;
    //    }

    //    if(head != null)
    //    {
    //      return head.value;
    //    }
    //    else
    //    {
    //      return  0;
    //    }
    //  }

    //}
    ////delete nth node
    //public  void DeleteNthNode(int nthNode)
    //{


    //}

    public void PrintAllNode()
    {
      int index = 0;
      if (head == null)
      {
        Console.WriteLine("no item in the list");
      }
      else
      {
        Node temp = head;
        Console.WriteLine("Node  " + index + " is " + head.value);
        while (temp.next != null)
        {
          index = index + 1;
          temp = temp.next;
          Console.WriteLine("Node " + index + " is " + temp.value);
        }
        Console.WriteLine("***************************************");
      }
    }

    //get n-1th index node
    public Node GetNodeBeforeIndex(int index)
    {
      //index cannot be 0 or less than 0
      int count = 0;
      var tempNode = this.head;

      while (count != index - 1)
      {
        tempNode = tempNode.next;
        count = count + 1;
      }
      return tempNode;
    }

    public Node GetNodeAtIndex(int index)
    {
      int count = 0;
      Node tempNode = this.head;
      while (count != index)
      {
        tempNode = tempNode.next;
        count = count + 1;
      }
      return tempNode;
    }
    //get  n+1th index node
    public Node GetNodeAfterIndex(int index)
    {
      // index cannot be lastindex or greater than lastindex
      int count = 0;
      Node tempNode = this.head;

      while (count != index + 1)
      {
        tempNode = tempNode.next;
        count = count + 1;
      }
      return tempNode;
    }

    public void InsertNodeAfterIndex(int index, int val)
    {
      if(index >= 0)
      {
        Node n = GetNodeAtIndex(index);
        Node after = GetNodeAfterIndex(index);
        Node newNode = new Node();
        Console.WriteLine("adding new node with value " +  val + "after index" + index);
        n.next = newNode;
        newNode.next = after;
        newNode.value = val;
      }
      else
      {
        Console.WriteLine("Incorrect value of index. Please pass values greater than or equal to zero");
      }
   
    }

    public void InsertNodeBeforeIndex (int index, int val)
    {
      if(index == 0)
      {
        Console.WriteLine("adding new node before index " + index + " with value " +  val);
        Node tempNewNode = new Node();
        tempNewNode.next = this.head;
        tempNewNode.value = val;
        this.head = tempNewNode;
      }
      else
      {
        Console.WriteLine("adding new node before index " + index + " with value " +  val);
        Node n = GetNodeBeforeIndex(index);
        Node nodeIndex = GetNodeAtIndex(index);
        Node temp = new Node();
        n.next = temp;
        temp.value = val;
        temp.next = nodeIndex;
      }
     
    }//close of method

  }
}
