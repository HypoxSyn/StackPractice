//Stacks are removed from top to bottom
//Can't access middle elements
//LIFO Last in, first out element
//Push(Object obj) method add data to stack at the top
//Object Peek (returns data at top of the stack)
//Stacks are defined like every other collection

//Queues- works like real life, first in, first out (FIFO)
//data can only be removed from back and removed from front
//OS IO requests,mouse movements
//Managing web request in server
//Queuing input from games
//---Enqueue (Object obj)- added to back
//---Object Dequeue()- removes top of the stack
//---Object Peek()- returns the object/data in front of queue without doing anything to it

//Only one type can belong to a Stack

Stack<int> stack = new();
stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(5);

while (stack.Count > 0)
{

    Console.WriteLine($"{stack.Peek()}");
    Console.Read();
    stack.Pop();
    int[] numbers = new int[] { 8, 2, 5, 6, 4, 7, 8, 2, 1 };

    Stack<int> _= new();
    
    foreach(int num in numbers)
    {
        Console.WriteLine(num + " " );
        _.Push(num);
    }
}



