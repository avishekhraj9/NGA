// See https://aka.ms/new-console-template for more information
// file handling in #
//Steps for file handling

//Step 1 Define a path

string filepath = "sample.txt";
string copypath = "copy.txt";

try
{
    //Step 2 Create a file
    Console.WriteLine("Creating a file...");
    File.Create(filepath).Close(); // Close the file stream after creating the file

    //Step 3 Write to the file
    Console.WriteLine("Writing to the file...");
    File.WriteAllText(filepath, "Hello, this is a sample file.");

    //Step 4 Append to the file
    Console.WriteLine("Appending to the file...");
    File.AppendAllText(filepath, "\nThis is an appended line.");

    //Step 5 Read from the file
    Console.WriteLine("Reading from the file...");
    string content = File.ReadAllText(filepath);
    Console.WriteLine(content);
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}