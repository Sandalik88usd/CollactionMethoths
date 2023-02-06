string[] fruitsArray = new string[3] {"apple", "banana", "orange" };
List<string> fruitsList = new List<string>();
List list = new List();
list.WriteToList(fruitsArray, fruitsList);
Console.WriteLine();
list.RemoveFromList(fruitsList);
Console.WriteLine();
//-------------------------------------
Queue<string> men = new Queue<string>();
List<string> menNames = new List<string>() {"Vova", "Kolya", "Oleg", "Anton" };
Queue queue = new Queue();
Console.WriteLine();
queue.AddMan(men, menNames);
Console.WriteLine();
queue.RemoveMan(men);
Console.WriteLine();
//-------------------------------------
Stack<string> passengers = new Stack<string>();
Stack stack = new Stack();
stack.GetOnTheBus(menNames, passengers);
Console.WriteLine();
stack.GetOffTheBus(passengers);
Console.WriteLine();
//-------------------------------------
Dictionary<string, string> phoneBook = new Dictionary<string, string>()
{
    {"Kostya", "6768245"},
    {"Fedir", "5424521"},
    {"Lida", "8539742"},
    {"Karina", "4567893"},
};
Dictionary dictionary = new Dictionary();
dictionary.FindNumber(phoneBook);
class List
{
    public void WriteToList(string[] fruitsArray, List<string> fruitsList)
    {
        for (int i = 0; i < fruitsArray.Length; i++)
        {
            fruitsList.Add(fruitsArray[i]);
            Console.Write(fruitsList[i] + " ");
        }
    }

    public void RemoveFromList(List<string> fruitsList)
    {
        fruitsList.RemoveAt(1);
        foreach (var fruitCounter in fruitsList)
        {
            Console.Write(fruitCounter + " ");
        }
    }
}


class Queue
{
    public void AddMan(Queue<string> men, List<string> menNames)
    {
        for (int i = 0; i < menNames.Count; i++)
        {
            men.Enqueue(menNames[i]);
            Console.WriteLine(menNames[i] + " Add to queue");
            Thread.Sleep(1000);
        }
    }
    
    public void RemoveMan(Queue<string> men)
    {
        for (int i = 0; i < men.Count; )
        {
            Console.WriteLine(men.Dequeue() + " Leave from queue");
            Thread.Sleep(1000);
        }
    }
}

class Stack
{
    public void GetOnTheBus(List<string> menNames, Stack<string> passengers)
    {
        for (int i = 0; i < menNames.Count; i++)
        {
            passengers.Push(menNames[i]);
            Console.WriteLine(menNames[i] + " get on the bus");
            Thread.Sleep(1000);
        }
    }
    public void GetOffTheBus(Stack<string> passengers)
    {
        for (int i = 0; i < passengers.Count; )
        {
            Console.WriteLine(passengers.Pop() + " get off the bus");
            Thread.Sleep(1000);
        }
    }
    
}

class Dictionary
{
    public void FindNumber(Dictionary<string, string> phoneBook)
    {
        string name;
        Console.WriteLine("List: ");
        foreach (var number in phoneBook)
            Console.WriteLine(number.Key);
        Console.WriteLine();
        while (true)
        {
            Console.Write("Write name to find number or write leave to exit: ");
            name = Console.ReadLine();
            if(name == "leave")
                break;
            foreach (var key in phoneBook)
            {
                if (name == key.Key)
                {
                    Console.WriteLine(key.Value);
                }
            }
        }

    }
}

// foreach (var key in phoneBook)
// {
//     Console.WriteLine("\n Don't find this name in phone book, \n choose name from list:");
//     foreach (var number in phoneBook)
//         Console.WriteLine(number.Key);
// }