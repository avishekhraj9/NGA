using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Demo_Day_5
{
    internal class Class1
    {
        //There are class where we can not rely on exception provided by the system, in such cases we can create our own custom exception class by inheriting from the base Exception class. This allows us to define our own error messages and properties that are specific to our application.
        //1) Checking for minor age for voting
        //2) Checking for negative numbers in a mathematical operation
        //3) checking for null values in a database query
        //4) checking for invalid input in a user registration form

        //all above cases are the example of custom exception handling, where we can create our own exception class and throw it when a specific condition is met. This allows us to provide more meaningful error messages and handle exceptions in a way that is specific to our application.
        //inheriting from base Exception class

        //Step for creating custom exception class:
        //Step 1: Create a new class that inherits from the base Exception class.
        //Step 2: Define a constructor that takes a string message as a parameter and passes it to the base Exception class constructor.
        //Step 3: Optionally, you can also define additional properties or methods in your custom exception class to provide more information about the error.
        //Step 4: Throw the custom exception in your code when a specific condition is met.
        //Step 5: Catch the custom exception in a catch block and handle it appropriately.
        //Step 6: Optionally, you can also log the custom exception or perform any other necessary actions in the catch block.


        //code for user defined exception handling for sleeping after midnight

    }
}

