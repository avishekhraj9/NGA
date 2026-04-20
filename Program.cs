using System.Collections;

Console.WriteLine("Hello, World!");


//non genereic collection
//arraylist 
//arraylist is a non generic collection which can store any type of data
//stack
//stack is a non generic collection which follows the LIFO (Last In First Out) principle'
//queue
//queue is a non generic collection which follows the FIFO (First In First Out) principle'
//hashtable
//hashtable is a non generic collection which stores key-value pairs

Console.WriteLine("Non Generic Collection");
Stack stack = new Stack(); //here i can store any type of data
stack.Push(1); //here i am storing an integer
stack.Push("Hello"); //here i am storing a string
stack.Push(3.14); //here i am storing a double
stack.Push(true); //here i am storing a boolean

Console.WriteLine("Length of stack: " + stack.Count); //here i am getting the length of stack'

Console.WriteLine("Retrieving data from stack");
while (stack.Count > 0)
{
    Console.WriteLine(stack.Pop()); //here i am retrieving data from stack


}

//Real world example of stack and queue
//stack is used in undo and redo operations in text editors
//Add to cart functionality in e-commerce websites uses stack to store the items added to the cart


//Creating hashtable
Console.WriteLine("Hashtable");
Hashtable hashtable = new Hashtable();
hashtable.Add("Name", "John"); //here i am adding a key-value pair to hashtable
hashtable.Add("Age", 30); //here i am adding a key-value pair to hashtable
hashtable.Add("City", "New York"); //here i am adding a key-value pair to hashtable

//Retrieving data from hashtable
Console.WriteLine("Retrieving data from hashtable");
Console.WriteLine("Name: " + hashtable["Name"]); //here i am retrieving data from hashtable using key
Console.WriteLine("Age: " + hashtable["Age"]); //here i am retrieving data from hashtable using key
Console.WriteLine("City: " + hashtable["City"]); //here i am retrieving data from hashtable using key
