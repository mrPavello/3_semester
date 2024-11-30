using System;
using System.Collections;
using System.Collections.Generic;

public class Node<T> 
{
    public T Data { get; set; }
    public Node<T>? Next { get; set; }
    public Node(T data)
    {
        Data = data; 
    }
}

public class Production
{
    public int id { get; set; }
    public string nameOrg { get; set; }

    public Production(int id, string nameOrg)
    {
        this.id = id;
        this.nameOrg = nameOrg;
    }
}

public class LinkedList<T> : IEnumerable<T>
{
    Node<T>? head;
    Node<T>? tail;
    public int count;
    Production production = new Production(22311, "<epam>");
    Developer developer = new Developer("Ляшко Алексей Валерьевич", 3345532, "Frontent-dev");
    public LinkedList()
    {
        head = null;
        tail = null;
        count = 0;
    }
    public void PrintList(LinkedList<T> list)
    {
        Console.Write("List: ");
        foreach(var node in list)
        {
            Console.Write($"{node} ");
        }
        Console.WriteLine();
    }
    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException(nameof(index));
            }
            Node<T>? current = head;
            for (int i = 0; i < index; i++)
            {
                current = current!.Next;
            }
            return current!.Data;
        }
    }
    public void Add(T data)
    {
        Node<T> node = new Node<T>(data);

        if (head == null)
        {
            head = node;
        }
        else
        {
            tail!.Next = node;
        }
        tail = node;
        count++;
    }

    public void AddToTop(T data)
    {
        Node<T> node = new Node<T>(data);

        node.Next = head;
        head = node;
        if (count == 0)
        {
            tail = head;
        }
        count++;
    }

    public bool Remove(T data)
    {
        Node<T>? current = head;
        Node<T>? previous = null;

        while (current != null && current.Data != null)
        {
            if(current.Data!.Equals(data))
            {
                if (previous != null)
                {
                    previous.Next = current.Next;
                    if (current.Next == null)
                    {
                        tail = previous;
                    }
                }
                else
                {
                    head = head?.Next;
                    if (head == null)
                    {
                        tail = null;
                    }
                }
                count--;
                return true;
            }
            previous = current;
            current = current.Next;
        }
        return false;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node<T>? current = head;
        while (current != null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public static LinkedList<T> operator +(LinkedList<T> List1, LinkedList<T> List2)
    {
        LinkedList<T> resultList = new LinkedList<T>();
        foreach (var node in List1)
        {
            resultList.Add(node);
        }
        foreach (var node in List2)
        {
            resultList.Add(node);
        }
        return resultList;
    }

    public static LinkedList<T> operator !(LinkedList<T> List)
    {
        LinkedList<T> invertedList = new LinkedList<T>();
        foreach (var node in List)
        {
            invertedList.AddToTop(node);
        }
        return invertedList;
    }

    public static bool operator ==(LinkedList<T> List1, LinkedList<T> List2)
    {
        if (List1.count != List2.count)
        {
            return false;
        }

        Node<T>? current1 = List1.head;
        Node<T>? current2 = List2.head;

        while (current1 != null)
        {
            if (!current1.Data!.Equals(current1.Data))
            {
                return false;
            }
            current1 = current1?.Next;
            current2 = current2?.Next;
        }
        return true;
    }

    public static bool operator !=(LinkedList<T> List1, LinkedList<T> List2)
    {
        return !(List1 == List2);
    }

    public static LinkedList<T> operator <(LinkedList<T> List1, LinkedList<T> List2)
    {
        foreach (var node in List2)
        {
            List1.Add(node);
        }
        return List1;
    }

    public static LinkedList<T> operator >(LinkedList<T> List1, LinkedList<T> List2)
    {
        foreach (var node in List1)
        {
            List2.Add(node);
        }
        return List2;
    }

    

    public class Developer
    {
        public string fio { get; set; }
        public int id { get; set; }
        public string departament { get; set; }

        public Developer(string fio, int id, string departament)
        {
            this.fio = fio;
            this.id = id;
            this.departament = departament;
        }
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        LinkedList<T> list = (LinkedList<T>)obj;
        if (count != list.count)
        {
            return false;
        }

        Node<T>? current = head;
        Node<T>? currentList = list.head;

        while (current != null)
        {
            if (!current.Data!.Equals(currentList))
            {
                return false;
            }
            current = current.Next;
            currentList = currentList.Next;
        }
        return true;
    }

    public override int GetHashCode()
    {
        int hash = 9;
        Node<T>? current = head;
        while (current != null)
        {
            hash = hash * 31 + (current.Data == null ? 0 : current.Data.GetHashCode());
            current = current.Next;
        }
        return hash;
    }

    public static int SumElements(LinkedList<int> list)
    {
        int sum = 0;
        foreach (var node in list)
        {
            sum += node;
        }
        return sum;
    }

}

public static class StatisticOperation
{
    public static int SumElements(LinkedList<int> list)
    {
        int sum = 0;
        foreach(var node in list)
        {
            sum += node;
        }
        return sum;
    }

    public static int DiffMaxMin(LinkedList<int> list)
    {
        if (list.count == 0)
        {
            throw new Exception("List is empty");
        }
        int max = list[0];
        int min = list[0];
        foreach (var node in list)
        {
            if (node > max)
            {
                max = node;
            }
            if (node < min)
            {
                min = node;
            }
        }
        return max - min;
    }

    public static int CountList(LinkedList<int> list)
    {
        return list.count;
    }

    public static string Truncate(this string str, int length)
    {
        if (str.Length <= length)
        {
            return str;
        }
        return str.Substring(0, length);
    }

    public static int SumListElements(this LinkedList<int> list)
    {
        int sum = 0;
        foreach (var node in list)
        {
            sum += node;
        }
        return sum;
    }
} 


class Programm
{
    static void Main()
    {
        LinkedList<int> list1 = new();
        list1.Add(1);
        list1.Add(2);
        list1.Add(3);
        list1.Add(4);
        list1.Add(5);

        list1.PrintList(list1);

        LinkedList<int> list2 = new();
        list2.Add(1);
        list2.Add(2);
        list2.Add(3);
        list2.Add(4);
        list2.Add(5);

        list2.PrintList(list2);

        LinkedList<int> concatedList = new();
        concatedList.PrintList(list1 + list2);

        LinkedList<int> invertedList = new();
        invertedList.PrintList(!list1);

        Console.WriteLine(list1 == list2);
        Console.WriteLine(list1 != list2);

        LinkedList<int> resultList = new();
        resultList.PrintList(invertedList < list1);

        string str = "good day";
        Console.WriteLine(str.Truncate(4));

        Console.WriteLine(list1.SumListElements());

        Console.WriteLine(StatisticOperation.SumElements(list2));
        Console.WriteLine(StatisticOperation.DiffMaxMin(list1));
        Console.WriteLine(StatisticOperation.CountList(list2));

        int i = LinkedList<int>.SumElements(list1);
        Console.WriteLine("\n");
        Console.WriteLine(i);
    }
}