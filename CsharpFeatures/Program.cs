

//C# features in 7 and 8 versions
//1. Out variables and Tuples
//2. Pattern matching
//3. Local functions
//4. Nullable reference types
//5. Async streams
//C# features in 9 and 10 versions
//1. Record types
//2. Init-only properties
//3. Top-level statements
// 4. Target-typed new expressions
// 5 . Improved pattern matching


//UB C# we have tupple types, but with C# 7 we can use them without creating a class or struct. We can also use out variables to declare variables inline when calling methods that have out parameters.
// for example:
// if i am having a method that calculates the area and perimeter of a rectangle, i can return a tupple with the area and perimeter values instead of creating a class or struct to hold those values.

(double area, double perimeter) CalculateRectangle(double length, double width)
{
    double area = length * width;
    double perimeter = 2 * (length + width);
    return (area, perimeter);
}

CalculateRectangle(5, 3);
CalculateRectangle(5, 4);

Console.WriteLine("the output of the method is:" + CalculateRectangle(5, 3));



// in pattern matching we can use the switch expression to match patterns and return values based on those patterns. For example, we can use pattern matching to determine the type of an object and return a specific value based on that type.
//Step 1: Define a method that takes an object as a parameter and uses pattern matching to determine its type and return a specific value based on that type.
//Step 2: Use the switch expression to match patterns and return values based on those patterns.

object obj = "Hello, World!";
if (obj is string str)
{
    Console.WriteLine($"The object is a string: {str}");
}
else if (obj is int num)
{
    Console.WriteLine($"The object is an integer: {num}");
}
else
{
    Console.WriteLine("The object is of an unknown type.");
}


// pattern matching can also be used with switch expressions to simplify code and make it more readable. For example, we can use a switch expression to determine the type of an object and return a specific value based on that type.
// example for switch expression with pattern matching:

object value = 42;
switch (value)
{
    case int i:
        Console.WriteLine($"The value is an integer: {i}");
        break;
    case string s:
        Console.WriteLine($"The value is a string: {s}");
        break;
    default:
        Console.WriteLine("The value is of an unknown type.");
        break;
}
